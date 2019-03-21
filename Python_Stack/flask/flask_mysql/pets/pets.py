from flask import Flask, render_template, request, redirect
from mysqlconnection import connectToMySQL
app = Flask(__name__)


@app.route("/")
def index():
    mysql = connectToMySQL('pet_db')
    pets = mysql.query_db('SELECT * FROM pets;')
    print(pets)
    return render_template("index.html", all_pets=pets)

@app.route('/add_pet', methods=['POST'])
def add_pet_to_db():
    mysql = connectToMySQL('pet_db')
    query = "INSERT INTO pets (name, type) VALUES (%(pn)s, %(pt)s);"
    data = {
        'pn': request.form['pet_name'],
        'pt': request.form['pet_type']
    }
    pet_id = mysql.query_db(query, data)
    return redirect('/')

if __name__ == "__main__":
    app.run(debug=True)