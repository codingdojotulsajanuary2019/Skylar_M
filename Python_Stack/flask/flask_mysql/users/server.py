from flask import Flask, render_template, request, redirect
from mysqlconnection import connectToMySQL
app = Flask(__name__)


@app.route('/')
def index_redir():
    return redirect('/users')

@app.route('/users')
def users_page():
    mysql = connectToMySQL('user_db')
    users = mysql.query_db('SELECT * FROM users;')
    print(users)
    return render_template("index.html", all_users=users)

@app.route('/users/new')
def show_page():
    return render_template('new_user.html')

@app.route('/adduser', methods=['POST'])
def add_new_user():
    mysql = connectToMySQL('user_db')
    query = 'INSERT INTO users (full_name, email) VALUES (%(fn)s, %(em)s);'
    data = {
        'fn': request.form['fname'],
        'em': request.form['email']
    }
    user_id = mysql.query_db(query, data)
    print(user_id)
    return redirect('/users/'+str(user_id))

@app.route('/users/<id>')
def view_profile(id):
    user_id = int(id)
    mysql = connectToMySQL('user_db')
    query = 'SELECT * FROM users WHERE id = %(user_id)s;'
    data = {'user_id': user_id}
    user = mysql.query_db(query, data)
    print(user_id)
    return render_template('profile.html', userinfo=user[0])

@app.route('/users/<id>/edit')
def edit_profile(id):
    user = int(id)
    mysql = connectToMySQL('user_db')
    query = 'SELECT * FROM users WHERE id = %(user_id)s;'
    data = {'user_id': user}
    user_id = mysql.query_db(query, data)
    return render_template('edit.html', userinfo=user_id)

@app.route('/edituser/<id>', methods=['POST'])
def edit_user(id):
    id_num = int(id)
    print(id_num)
    mysql = connectToMySQL('user_db')
    query = 'UPDATE users SET full_name = %(fn)s, email = %(em)s WHERE id = %(id)s;'
    data = {
        'id': id_num,
        'fn': request.form['fname'],
        'em': request.form['email']
    }
    execute = mysql.query_db(query, data)
    return redirect('/users')

@app.route('/delete_user/<id>')
def delete_user(id):
    id_num = int(id)
    print(id_num)
    mysql = connectToMySQL('user_db')
    query = 'DELETE FROM users WHERE id = %(id)s;'
    data = {
        'id': id_num
    }

    execute = mysql.query_db(query, data)
    return redirect('/users')



if __name__ == "__main__":
    app.run(debug=True)