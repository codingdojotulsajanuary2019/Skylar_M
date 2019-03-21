from flask import Flask, render_template, request, redirect, session, flash
from mysqlconnection import connectToMySQL
import re
from flask_bcrypt import Bcrypt
from datetime import datetime
from flask_humanize import Humanize
app = Flask(__name__)
humanize = Humanize(app)
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
        mysql = connectToMySQL('fav_books_db')
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
        return redirect('/profile')
    return redirect('/')


@app.route('/login', methods=['post'])
def login():
    mysql = connectToMySQL('fav_books_db')
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
            return redirect ('/profile')
        else:
            flash(u'Invalid email or password', 'login_error')
            return redirect('/')

@app.route('/logout')
def logout():
    session.clear()
    return redirect('/')

@app.route('/profile')
def profile():
    if session['user_id']:
        mysql = connectToMySQL('fav_books_db')
        users = mysql.query_db('SELECT * FROM users;')

        mysql = connectToMySQL('fav_books_db')
        books = mysql.query_db('SELECT * FROM books;')

        mysql = connectToMySQL('fav_books_db')
        favs = mysql.query_db('SELECT * FROM favorites;')


        return render_template('profile.html', all_users=users, all_books=books, all_favs=favs)
    else:
        return render_template('error.html')


@app.route('/library')
def library():
    mysql = connectToMySQL('fav_books_db')
    users = mysql.query_db('SELECT * FROM users;')
    
    mysql =  connectToMySQL('fav_books_db')
    books = mysql.query_db('SELECT * FROM books ORDER BY title asc;')

    mysql = connectToMySQL('fav_books_db')
    favs = mysql.query_db('SELECT * FROM favorites;')

    return render_template('library.html', all_users = users, all_books = books, all_favs = favs)


@app.route('/add_book', methods=['post'])
def add_book():
    is_valid= True
    if len(request.form['title']) < 2:
        is_valid = False
        flash(u'Please enter a valid title')
    if len(request.form['author']) < 4:
        is_valid = False
        flash(u'Please enter a valid title')
    
    if is_valid == True:
        
        mysql = connectToMySQL('fav_books_db')
        query = 'INSERT INTO books (title, author, description, uploaded_by_id) VALUES (%(title)s, %(author)s, %(desc)s, %(ulby)s);'
        print(query)
        data = {
            'title': request.form['title'],
            'author': request.form['author'],
            'desc': request.form['description'],
            'ulby': request.form['uploaded_by_id']
        }
        print(data)
        book_id = mysql.query_db(query, data)
        print(book_id)

    return redirect('/library')

@app.route('/add_to_favs', methods=['post'])
def add_to_favs():
    mysql = connectToMySQL('fav_books_db')
    query = 'INSERT INTO favorites (user_id, book_id) VALUES (%(user)s, %(book)s);'
    data = {
        'user': request.form['user_id'],
        'book': request.form['book_id']
    }
    fav_id = mysql.query_db(query, data)
    
    return redirect('/library')


if __name__ == "__main__":
    app.run(debug=True)