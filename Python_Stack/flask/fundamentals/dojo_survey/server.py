from flask import Flask, render_template, request, redirect, flash
from mysqlconnection import connectToMySQL
app = Flask(__name__)
app.secret_key = 'pineapple'

@app.route('/')
def survey_index():
    return render_template('index.html')

@app.route('/addresult', methods=['POST'])
def post_result():
    print('Got Post')
    print(request.form)
    
    is_valid = True
    
    if len(request.form['student_name']) < 1:
        is_valid = False
        flash('Please enter a name.')
    
    if len(request.form['location']) < 1:
        is_valid = False
        flash('Please select a location.')
    
    if len(request.form['fav_lang']) < 1:
        is_valid = False
        flash('Please select a language.')
    

    if is_valid:
        mysql = connectToMySQL('dojo_survey_db')
        query = 'INSERT INTO results (name, location, favorite_language, comment) VALUES (%(nm)s, %(loc)s, %(lang)s, %(com)s);'
        data = {
            'nm': request.form['student_name'],
            'loc': request.form['location'],
            'lang': request.form['fav_lang'],
            'com': request.form['comment'],
        }
        result_id = mysql.query_db(query, data)
        print(result_id)
        return redirect('/result/' + str(result_id))

    else: return redirect('/')

@app.route('/result/<id>')
def get_result_page(id):
    result_id = int(id)
    mysql = connectToMySQL('dojo_survey_db')
    query = 'SELECT * FROM results WHERE id = %(result_id)s'
    data = {
        'result_id': result_id
        }
    result = mysql.query_db(query, data)
    return render_template('result.html', result=result[0])


if __name__ == "__main__":
    app.run(debug=True)