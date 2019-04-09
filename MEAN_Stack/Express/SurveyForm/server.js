
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
  if(session.count == null){
    console.log('$$$$');
    console.log(session.count);
    console.log('$$$$');
    session.count = 1;
  }
  else{
    console.log('****');
    console.log(session.count);
    console.log('****');
    session.count++;
  }
  response.render('index', {count: session.count});
})
app.get('/2', function(request, response){
  session.count++;
  response.redirect('/');
})
app.get('/reset', function(request, response){
  session.count = 0;
  response.redirect('/');
})


// tell the express app to listen on port 8000, always put this at the end of your server.js file
app.listen(8000, function() {
  console.log("listening on port 8000");
})