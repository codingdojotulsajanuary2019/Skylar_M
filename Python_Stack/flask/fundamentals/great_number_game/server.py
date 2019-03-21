from flask import Flask, render_template, request, redirect, session
import random
app = Flask(__name__)
app.secret_key = 'pineapple'

cpu_num = random.randint(1,100)

@app.route('/')
def index():
    print('#'*6)
    print(cpu_num)
    print('#'*6)
    return render_template('index.html', cpu=cpu_num)

@app.route('/process', methods=['POST'])
def proc_guess():
    player_num = int(request.form['guess_num'])
    print(cpu_num)
    return render_template('index.html',cpu=cpu_num, player_num=player_num)



if __name__ == "__main__":
    app.run(debug=True)