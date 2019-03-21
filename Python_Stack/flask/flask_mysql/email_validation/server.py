from flask import Flask, render_template, request, redirect, flash
from mysqlconnection import connectToMySQL
import re
app = Flask(__name__)
app.secret_key = 'pineapple'

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$') 

@app.route('/')
def val_index():
    return render_template('index.html')


@app.route('/process', methods=['POST'])
def submit():
    if not EMAIL_REGEX.match(request.form['email']):    # test whether a field matches the pattern
        flash("Invalid email address!")
        return redirect('/')

    else:
        mysql = connectToMySQL('email_val_db')
        query = 'INSERT INTO emails (address) VALUES (%(em)s);'
        data = {
            'em': request.form['email']
        }
        email_id = mysql.query_db(query, data)
        return redirect('/table')




@app.route('/table')
def show_email():
    mysql = connectToMySQL('email_val_db')
    users = mysql.query_db('SELECT * FROM emails;')
    flash("Submission Successful!")
    return render_template('table.html', all_users=users)






if __name__ == "__main__":
    app.run(debug=True)