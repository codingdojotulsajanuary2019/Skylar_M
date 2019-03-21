from flask import Flask, render_template, request, redirect
app = Flask(__name__)  

@app.route('/')         
def index():
    return render_template("index.html")

@app.route('/checkout', methods=['POST'])         
def checkout():
    num_straw = request.form['strawberry']
    num_rasp = request.form['raspberry']
    num_black = request.form['blackberry']
    num_app = request.form['apple']
    total_num = int(num_straw) + int(num_rasp) + int(num_black) + int(num_app)
    form_fname = request.form['first_name']
    form_lname = request.form['last_name']
    form_id = request.form['student_id']
    print(request.form)
    print('$'*80)
    print(f'Charging customer {form_fname} {form_lname} for {total_num} fruits.')
    print('$'*80)
    return render_template("checkout.html", template_straw=num_straw, template_rasp=num_rasp, template_black=num_black, template_app=num_app, temp_total=total_num, fname=form_fname, lname=form_lname, temp_id=form_id)

@app.route('/fruits')         
def fruits():
    return render_template("fruits.html")

if __name__=="__main__":   
    app.run(debug=True)    