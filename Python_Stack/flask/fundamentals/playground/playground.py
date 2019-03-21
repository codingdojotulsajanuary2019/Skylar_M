from flask import Flask, render_template
app = Flask(__name__)

@app.route('/play/<num>/<color>')
def lets_play(num, color):
    num = int(num)
    return render_template('index.html', box_color=color, boxes=num)



if __name__ == "__main__":
    app.run(debug=True)