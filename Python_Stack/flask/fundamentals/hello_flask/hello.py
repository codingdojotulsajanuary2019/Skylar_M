from flask import Flask, render_template
app = Flask(__name__)
@app.route('/')
def hello_world():
    return render_template('index.html', phrase='hello', times=5)

@app.route('/<name>')
def hello_name(name):
    print(name)
    return render_template('index.html', some_name=name)


@app.route('/success')
def success():
    return 'success'

@app.route('/users/<username>/<id>')
def show_profile(username, id):
    print(username)
    print(id)
    return f'username: {username}, id: {id}'

@app.route('/lists')
def render_lists():
    student_info = [
        {'name' : 'Michael', 'age' : 35},
        {'name' : 'John', 'age' : 30},
        {'name' : 'Mark', 'age' : 25},
        {'name' : 'KB', 'age' : 27}
    ]
    return render_template("lists.html", random_numbers = [3,1,5], students = student_info)

@app.route('/table')
def render_table():
    user_info = [
        {'first_name' : 'Michael', 'last_name' : 'Choi'},
        {'first_name' : 'John', 'last_name' : 'Supsupin'},
        {'first_name' : 'Mark', 'last_name' : 'Guillen'},
        {'first_name' : 'KB', 'last_name' : 'Tonel'}
    ]
    return render_template('table.html', users = user_info)

if __name__ == "__main__":
    app.run(debug=True)