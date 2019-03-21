var users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}];
function findAge(x){
    for(i=0; i<x.length; i++){
        if(users[i].name === "John"){
            return users[i].age;
        }
    }
}
console.log(findAge(users));

--------------------------------------

var users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}];
function nameObj1(x){
    for(i=0; i<x.length; i++){
        if(i===0){
            return x[i].name;
        }
    }
}
console.log(nameObj1(users));

--------------------------------------

var users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}];
function listInfo(x){
    for(i=0; i<x.length; i++){
        console.log(x[i].name, x[i].age);
    }
}
var list = listInfo(users);