from flask import Flask, render_template, request, redirect, session
import random
app = Flask(__name__)
app.secret_key = 'pineapple'


@app.route("/")
def index():
    session['gold'] = 0
    return render_template("index.html")

@app.route("/process", methods=['POST'])
def process():
    count = 0
    activity_log = [" "]
    
    
    if request.form['which_form'] == 'farm':
        session['gold'] += random.randint(10,20)
        activity_log[count] = 'Earned gold'
        count += 1
    
    if request.form['which_form'] == 'cave':
        session['gold'] += random.randint(5,10)
    
    
    if request.form['which_form'] == 'house':
        session['gold'] += random.randint(2,5)
    
    
    if request.form['which_form'] == 'casino':
        session['gold'] += random.randint(-50,50)
    return render_template("index.html")

@app.route("/clear")
def clearsession():
    session.clear()
    return redirect("/")

if __name__ == "__main__":
    app.run(debug=True)