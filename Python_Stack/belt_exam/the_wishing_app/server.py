from flask import Flask, render_template, request, redirect, session, flash
from mysqlconnection import connectToMySQL
import re
from flask_bcrypt import Bcrypt
from datetime import datetime
from flask_humanize import Humanize
app = Flask(__name__)
bcrypt = Bcrypt(app)
app.secret_key = 'pineapple'

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$') 

@app.route('/')
def index():
    return render_template('index.html')

@app.route('/processnewuser', methods = ['POST'])
def new_user():
    is_valid = True
    
    if not request.form['first_name'].isalpha():
        is_valid = False
        flash(u'Please enter a valid first name', 'registration_error')
    if len(request.form['first_name']) < 2:
        is_valid = False
        flash(u'Please enter a valid first name', 'registration_error')
    
    if not request.form['last_name'].isalpha():
        is_valid = False
        flash(u'Please enter a valid last name', 'registration_error')
    if len(request.form['last_name']) < 2:
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
        mysql = connectToMySQL('wish_db')
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
        return redirect('/wishes')
    return redirect('/')


@app.route('/login', methods=['post'])
def login():
    mysql = connectToMySQL('wish_db')
    query = 'SELECT * FROM users WHERE email = %(email)s;'
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
            return redirect ('/wishes')
        else:
            flash(u'Invalid email or password', 'login_error')
            return redirect('/')
    else:
        flash(u'Invalid email or password', 'login_error')
        return redirect('/')

@app.route('/wishes')
def userhome():
    try:
        session['user_id']
        mysql = connectToMySQL('wish_db')
        users = mysql.query_db('SELECT * FROM users;')
        
        mysql = connectToMySQL('wish_db')
        wishes = mysql.query_db('SELECT * FROM wishes;')


        return render_template('dashboard2.html', all_users=users, all_wishes=wishes)
    except:
        return render_template('error.html')


@app.route('/make_wish')
def make_wish():

    return render_template('make_wish.html')

@app.route('/processnewwish', methods=['POST'])
def new_wish():
    is_valid = True
    if len(request.form['item']) < 3:
        is_valid = False
        flash('Item must be at least 3 characters')
    if len(request.form['description']) < 3:
        is_valid = False
        flash('Description must be at least 3 characters')
        
    if is_valid == True:
        mysql = connectToMySQL('wish_db')
        query = 'INSERT INTO wishes (item, description, user_id) VALUES (%(item)s, %(desc)s, %(user)s);'
        data = {
            'item': request.form['item'],
            'desc': request.form['description'],
            'user': request.form['user_id']
        }
        wish_id = mysql.query_db(query, data)
        print('$'*40)
        print(request.form['user_id'])
        print(session['user_id'])
        print('$'*40)
        return redirect('/wishes')
    return redirect('/make_wish')


@app.route('/delete_wish', methods=['POST'])
def delete_message():
    mysql = connectToMySQL('wish_db')
    query = 'DELETE FROM wishes WHERE wish_id = %(id)s;'
    data = {
        'id': request.form['wish_id']
    }
    execute = mysql.query_db(query, data)
    return redirect('/wishes')

@app.route('/wish/<id>/edit')
def edit_profile(id):
    wish = int(id)
    mysql = connectToMySQL('wish_db')
    query = 'SELECT * FROM wishes WHERE id = %(wish_id)s;'
    data = {'wish_id': wish}
    wish_list = mysql.query_db(query, data)
    return render_template('edit_wish.html', wish_id=wish)

@app.route('/edit_wish/<id>', methods=['POST'])
def edit_user(id):
    id_num = int(id)
    print(id_num)
    is_valid = True
    if len(request.form['item']) < 3:
        is_valid = False
        flash('Item must be at least 3 characters')
    if len(request.form['description']) < 3:
        is_valid = False
        flash('Description must be at least 3 characters')
        
    if is_valid == True:
        mysql = connectToMySQL('wish_db')
        query = 'UPDATE wishes SET item = %(item)s, description = %(desc)s WHERE wish_id = %(id)s;'
        data = {
            'id': id_num,
            'item': request.form['item'],
            'desc': request.form['description']
        }
        execute = mysql.query_db(query, data)
        return redirect('/wishes')
    return redirect(f'/wish/{id}/edit')


@app.route('/grant_wish', methods=['post'])
def grant():
    mysql = connectToMySQL('wish_db')
    query = 'UPDATE wishes SET granted = %(value)s WHERE wish_id = %(id)s;'
    data = {
        'id': request.form['wish_id'],
        'value': request.form['granted']
    }
    execute = mysql.query_db(query, data)
    return redirect('/wishes')



@app.route('/logout', methods=['post'])
def logout():
    session.clear()
    return redirect('/')





if __name__ == "__main__":
    app.run(debug=True)