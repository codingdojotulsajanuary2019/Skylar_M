from flask import Flask, render_template
app = Flask(__name__)


@app.route('/')
def default_board():
    return render_template('checkerboard.html', num_rows=1, num_col=1)


@app.route('/<x>/<y>')
def define_rows(x,y):
    x = int(x) // 2
    y = int(y) // 2
    return render_template('checkerboard.html', num_rows=x, num_col=y)




if __name__ == "__main__":
    app.run(debug=True)