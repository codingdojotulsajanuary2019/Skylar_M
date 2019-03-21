from flask import Flask, render_template, request, redirect, session, flash
from mysqlconnection import connectToMySQL
import re
from flask_bcrypt import Bcrypt
app = Flask(__name__)
bcrypt = Bcrypt(app)
app.secret_key = 'pineapple'

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$') 

@app.route('/')
def index():
    return render_template('index.html')

@app.route('/processnewuser', methods = ['POST'])
def new_user():
    is_valid= True
    if not request.form['first_name'].isalpha() and (len(request.form['first_name']) < 2):
        is_valid = False
        flash(u'Please enter a valid first name', 'registration_error')
    if not request.form['last_name'].isalpha() and (len(request.form['last_name']) < 2):
        is_valid = False
        flash(u'Please enter a valid last name', 'registration_error')
    if not EMAIL_REGEX.match(request.form['email']):
        is_valid = False
        flash(u'Please enter a valid email address', 'registration_error')
    if len(request.form['password']) < 8:
        is_valid = False
        flash(u'Password must contain at least 8 characters', 'registration_error')
    if request.form['password'] != request.form['password_confirmation']:
        is_valid = False
        flash(u'Passwords did not match', 'registration_error')
    
    if is_valid == True:
        password_hash = bcrypt.generate_password_hash(request.form['password'])
        print('*'*80)
        print(password_hash)
        print('*'*80)
        mysql = connectToMySQL('login_and_regis_db')
        query = 'INSERT INTO users (first_name, last_name, email, password_hash) VALUES (%(first)s, %(last)s, %(email)s, %(pass)s);'
        print(query)
        data = {
            'first': request.form['first_name'],
            'last': request.form['last_name'],
            'email': request.form['email'],
            'pass': password_hash
        }
        print(data)
        user_id = mysql.query_db(query, data)
        print(user_id)
        session['user_id'] = user_id
        print(session['user_id'])
        print("WTF")
        return redirect('/success')
    return redirect('/')


@app.route('/login', methods=['post'])
def login():
    mysql = connectToMySQL('login_and_regis_db')
    query = 'SELECT * FROM users WHERE email = %(email)s'
    data = {
        'email': request.form['existing_user_email']
        }
    userdata = mysql.query_db(query, data)
    print('*'*80)
    print(userdata)
    print('*'*80)
    if userdata:
        if bcrypt.check_password_hash(userdata[0]['password_hash'], request.form['existing_user_password']):
            session['user_id'] = userdata[0]['id']
            return redirect ('/success')
        else:
            flash(u'Invalid email or password', 'login_error')
            return redirect('/')

@app.route('/success')
def userhome():
    if session['user_id']:
        return render_template('userhome.html')
    else:
        return render_template('error.html')

@app.route('/logout', methods=['post'])
def logout():
    session.clear()
    return redirect('/')



if __name__ == "__main__":
    app.run(debug=True)