
var express = require("express");
var session = require("express-session");
var app = express();
app.use(express.static(__dirname + "/static"));
app.use(session({
  secret: 'skylar', 
  resave: false,
  saveUninitialized: true,
  cookie: { maxAge: 60000},
}));
app.set('views', __dirname + '/views'); 
app.set('view engine', 'ejs');

app.get('/', function(request, response){
  response.render('index');
})

// tell the express app to listen on port 8000, always put this at the end of your server.js file
app.listen(8000, function() {
  console.log("listening on port 8000");
})