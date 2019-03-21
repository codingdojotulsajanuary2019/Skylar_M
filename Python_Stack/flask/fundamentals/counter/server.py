from flask import Flask, render_template, request, redirect, session, random
app = Flask(__name__)
app.secret_key = 'pineapple'

@app.route('/')
def index():


if __name__ == "__main__":
    app.run(debug=True)