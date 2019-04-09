
// Load the express module and store it in the variable express (Where do you think this comes from?)
var express = require("express");
console.log("Let's find out what express is", express);
// invoke express and store the result in the variable app
var app = express();
console.log("Let's find out what app is", app);
// use app's get method and pass it the base route '/' and a callback

app.use(express.static(__dirname + "/static"));

// This sets the location where express will look for the ejs viewscopy
app.set('views', __dirname + '/views'); 
// Now lets set the view engine itself so that express knows that we are using ejs as opposed to another templating engine like jade
app.set('view engine', 'ejs');

app.get('/cars', function(request, response){
  
  response.render('cars');
})
app.get('/cats', function(request, response){
  response.render('cats');
})
app.get('/cat1', function(request, response){
  var catInfo = {
    pictureLoc: "/images/cat1.jpg",
    favoriteFood: "Fried Mushrooms",
    age: "100,000 years old",
    sleepingSpots: "In your mother's bed in every dimension"
  };
  response.render('cat_details', {cat: catInfo});
})
app.get('/cat2', function(request, response){
  var catInfo = {
    pictureLoc: "/images/cat2.jpg",
    favoriteFood: "Ice Cream",
    age: "3 months old",
    sleepingSpots: "In a hammock by the beach"
  };
  response.render('cat_details', {cat: catInfo});
})
app.get('/cat3', function(request, response){
  var catInfo = {
    pictureLoc: "/images/cat3.jpg",
    favoriteFood: "Spaghetti",
    age: "4 years old",
    sleepingSpots: "Where you least expect it muahahaha."
  };
  response.render('cat_details', {cat: catInfo});
})
app.get('/form', function(request, response){
  response.render('form');
})

// tell the express app to listen on port 8000, always put this at the end of your server.js file
app.listen(8000, function() {
  console.log("listening on port 8000");
})