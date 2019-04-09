let students = [
    {name: 'Remy', cohort: 'Jan'},
    {name: 'Genevieve', cohort: 'March'},
    {name: 'Chuck', cohort: 'Jan'},
    {name: 'Osmund', cohort: 'June'},
    {name: 'Nikki', cohort: 'June'},
    {name: 'Boris', cohort: 'June'}
];

let users = {
    employees: [
        {'first_name' :  'Miguel', 'last_name' : 'Jones'},
        {'first_name' : 'Ernie', 'last_name' : 'Bertson'},
        {'first_name' : 'Nora', 'last_name' : 'Lu'},
        {'first_name' : 'Sally', 'last_name' : 'Barkyoumb'}
    ],
    managers: [
       {'first_name' : 'Lillian', 'last_name' : 'Chambers'},
       {'first_name' : 'Gordon', 'last_name' : 'Poe'}
    ]
 };



function studentInfo(arr){
    for(var student in students){
        console.log(`Name: ${students[student].name}, Cohort: ${students[student].cohort}`);
    }
}

function numCharOfNameInUsers(){
    for(var key in users){
        console.log(key)
        for(var obj in users[key]){
            var fname = users[key][obj].first_name;
            var lname = users[key][obj].last_name;
            var length = (users[key][obj].first_name + users[key][obj].last_name).length;
            var num = Number(obj) + 1;
            console.log(`${num} - ${lname}, ${fname} - ${length}`)
        }
    }
}


studentInfo(students);
console.log("**********************************************");
numCharOfNameInUsers(users);

