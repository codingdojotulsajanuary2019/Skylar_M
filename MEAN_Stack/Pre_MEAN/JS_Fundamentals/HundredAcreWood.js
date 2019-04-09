var heffalumps = {character: "Heffalumps"};
var eeyore = {character: "Eeyore"};
var kanga = {character: "Kanga"};
var owl = {character: "Owl"};
var christopher = {character: "Christopher Robin"};
var rabbit = {character: "Rabbit"};
var gopher = {character: "Gopher"};
var piglet = {character: "piglet"};
var winnie = {character: "Winnie the Pooh"};
var bees = {character: "Bees"};
var tigger = {character: "Tigger"};
heffalumps.west = eeyore;
eeyore.east = heffalumps;
eeyore.south = kanga;
kanga.north = eeyore;
kanga.south = christopher;
owl.south = piglet;
owl.east = christopher;
christopher.west = owl;
christopher.north = kanga;
christopher.east = rabbit;
christopher.south = winnie;
rabbit.west = christopher;
rabbit.east = gopher;
rabbit.south = bees;
gopher.west = rabbit;
piglet.east = winnie;
piglet.north = owl;
winnie.west = piglet;
winnie.north = christopher;
winnie.east = bees;
winnie.south = tigger;
bees.west = winnie;
bees.north = rabbit;
tigger.north = winnie;

var player = {character: "Skylar"};
player.location = tigger;

function move(direction){
    if(player.location.direction == null){
        return("Don't wander too far into the woods!")
    }
    else{
        player.location = player.location.direction;
        return(`You are now at ${player.location.character}'s house.`)
    }
}
