var hello;
console.log(hello);
hello = 'world';

//output = undefined//

function test(){
	var needle = 'magnet';
	console.log(needle);
}
var needle;
needle = 'haystack';
test();

//output = magnet//

function print(){
	brendan = 'only okay';
	console.log(brendan);
}
var brendan;
brendan = 'super cool';
console.log(brendan);

//output = super cool//

function eat(){
	food = 'half-chicken';
	console.log(food);
	var food = 'gone';
}
var food;
food = 'chicken';
console.log(food);
eat();

//output = chicken, half-chicken//

var mean;
console.log(food);
mean = function() {
    food = "chicken";
	console.log(food);
	var food = "fish";
	console.log(food);
}
mean();
console.log(food);

//output = TypeError//

function rewind() {
	genre = "rock";
	console.log(genre);
	var genre = "r&b";
	console.log(genre);
}
var genre;
console.log(genre);
genre = "disco";
rewind();
console.log(genre);

// output = undefined, rock, r&b, disco //

function learn() {
	dojo = "seattle";
	console.log(dojo);
	var dojo = "burbank";
	console.log(dojo);
}
dojo = "san jose";
console.log(dojo);
learn();
console.log(dojo);

//output = san jose, seattle, burbank, san jose //

