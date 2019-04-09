// $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$**CONFIG**$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ //

const express = require('express');
const app = express();
const PORT = 8000;
const session = require('express-session');
const path = require('path');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const flash = require('express-flash');

app.use(express.static(path.join(__dirname, './static')));

app.use(bodyParser.urlencoded({extended: true}));

app.use(session({
    secret: 'cdjsmm',
    resave: false,
    saveUninitialized: true,
    cookie: { maxAge: 60000 }
  }))

app.use(flash());

app.set('views', path.join(__dirname, './views'));
app.set('view engine', 'ejs');

mongoose.connect('mongodb://localhost/quoting_dojo', { useNewUrlParser: true });

// $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$**SCHEMAS**$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ //

var QuoteSchema = new mongoose.Schema({
    name: {type: String, required: true, minlength: 2},
    content: {type: String, required: true, minlength: 10},
    created_at: {type: Date, default: Date.now}
    },{timeStamps: true})
mongoose.model('Quote', QuoteSchema);
var Quote = mongoose.model('Quote');

// $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$**ROUTES**$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ //


// ###########**INDEX**########### //

app.get('/', function(request, response){
    response.render('index');
})

// ######**QUOTE-POST-ROUTE**###### //

app.post('/quotes', function(request, response){
    var quote = new Quote({name: request.body.name, content: request.body.quote});
    quote.save(function(err){
        if(err){
            for(var x in err.errors){
                request.flash('submission', err.errors[x].message);
            }
            response.redirect('/');
        }
        else{
            response.redirect('/quotes');
        }
    })
})

// #########**MAIN-PAGE**######### //

app.get('/quotes', function(request, response){
    Quote.find({}, function(err, quotes){
        console.log(quotes);
        if(quotes){
            response.render('quotes', {Quotes: quotes});
        }
        else{
            response.render('quotes');
        }
    }).sort({_id: 1})
})








// $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ //

app.listen(PORT, function() {
    console.log(`listening on port ${PORT}`);
})