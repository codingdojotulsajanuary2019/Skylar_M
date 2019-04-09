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

var PokeSchema = new mongoose.Schema({
    name: {type: String, required: true, minlength: 2},
    type: {type: String, required: true},
    move1: {type: String, required: true},
    move2: {type: String, required: true},
    created_at: {type: Date, default: Date.now}
    },{timeStamps: true})
mongoose.model('Pokemon', PokeSchema);
var Pokemon = mongoose.model('Pokemon');

// $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$**ROUTES**$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ //


// ###########**DISPLAY-ALL**########### //

app.get('/', function(request, response){
    Pokemon.find({}, function(err, pokemon){
        console.log(pokemon);
        if(pokemon){
            response.render('index', {Pokemon: pokemon});
        }
        else{
            response.render('new');
        }
    }).sort({_id: 1})
})

// ######**NEW-POKEMON-ROUTE**###### //

app.get('/pokemon/new', function(request, response){
    response.render('new')
})

// ######**NEW-POKEMON-POST-ROUTE**###### //

app.post('/pokemon/new', function(request, response){
    var pokemon = new Pokemon({name: request.body.name, type: request.body.type, move1: request.body.move1, move2: request.body.move2});
    pokemon.save(function(err){
        if(err){
            for(var x in err.errors){
                request.flash('submission', err.errors[x].message);
            }
            response.redirect('/new');
        }
        else{
            response.redirect('/');
        }
    })
})

// #########**POKEMON-INFO**######### //

app.get('/pokemon/:id', function(request, response){
    console.log(request.params.id);
    Pokemon.find({_id: request.params.id}, function(err, pokemon){
        console.log(pokemon);
        if(pokemon){
            response.render('info', {Pokemon: pokemon});
        }
        else{
            response.redirect('/');
        }
    })
})

// #########**POKEMON-EDIT-VIEW**######### //

app.get('/pokemon/edit/:id', function(request, response){
    Pokemon.find({_id: request.params.id}, function(err, pokemon){
        console.log(pokemon);
        console.log("********************************")
        if(pokemon){
            response.render('edit', {Pokemon: pokemon});
        }
        else{
            response.redirect('/');
        }
    })
})

// #########**POKEMON-EDIT-POST**######### //

app.post('/pokemon/edit/:id', function(request, response){
    console.log("POST ROUTE");
    Pokemon.findOneAndUpdate({_id: request.params.id}, {$set:{name: request.body.name, type: request.body.type, move1: request.body.move1, move2: request.body.move2}}, {new: true}, function(err, pokemon){
        console.log(pokemon);
        if(pokemon){
            response.redirect(`/pokemon/${request.params.id}`)
        }
        else{
            response.redirect('/');
        }
    })
})

// #########**POKEMON-DELETE**######### //

app.post('/pokemon/delete/:id', function(request, response){
    Pokemon.deleteOne({_id: request.params.id}, function(err){
        if(err){
            response.render(`/pokemon/${request.params.id}`);
        }
        else{
            response.redirect('/');
        }
    })
})

// $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ //

app.listen(PORT, function() {
    console.log(`listening on port ${PORT}`);
})