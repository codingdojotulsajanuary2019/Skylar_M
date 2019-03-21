from flask import Flask, render_template, request, redirect, flash
from mysqlconnection import connectToMySQL
app = Flask(__name__)
app.secret_key = 'pineapple'

@app.route("/")
def index():
    mysql = connectToMySQL('flask_friends')
    friends = mysql.query_db('SELECT * FROM friends;')
    print(friends)
    return render_template("index.html", all_friends=friends)

@app.route("/create_friend", methods=["POST"])
def add_friends_to_db():
    is_valid = True
    if len(request.form['fname']) < 1:
        is_valid = False
        flash('Please enter a first name.')
    if len(request.form['lname']) < 1:
        is_valid = False
        flash('Please enter a last name.')
    if len(request.form['occ']) < 2:
        is_valid = False
        flash('Occupation must be more than 2 characters')

    if is_valid:
        mysql = connectToMySQL('flask_friends')
        query = "INSERT INTO friends (first_name, last_name, occupation, created_at, updated_at) VALUES (%(fn)s, %(ls)s, %(occup)s, NOW(), NOW());"
        data = {
            "fn": request.form["fname"],
            "ln": request.form["lname"],
            "occup": request.form["occ"]
        }
        new_friend_id = mysql.query_db(query, data)
        print(request.form)
    return redirect('/')

if __name__ == "__main__":
    app.run(debug=True)
