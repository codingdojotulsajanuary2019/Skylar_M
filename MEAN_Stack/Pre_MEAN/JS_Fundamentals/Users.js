users = [
    {
      fname: "Kermit",
      lname: "the Frog",
      languages: ["Python", "JavaScript", "C#", "HTML", "CSS", "SQL"],
      interests: {
        music: ["guitar", "flute"],
        dance: ["tap", "salsa"],
        television: ["Black Mirror", "Stranger Things"]
      }
    },
    {
      fname: "Winnie",
      lname: "the Pooh",
      languages: ["Python", "Swift", "Java"],
      interests: {
        food: ["honey", "honeycomb"],
        flowers: ["honeysuckle"],
        mysteries: ["Heffalumps"]
      }
    },
    {
      fname: "Arthur",
      lname: "Dent",
      languages: ["JavaScript", "HTML", "Go"],
      interests: {
        space: ["stars", "planets", "improbability"],
        home: ["tea", "yellow bulldozers"]
      }
    }
  ]
function userLanguages(arr){
    for(var i =0; i<arr.length; i++){
        var str = "";
        str+= `${arr[i].fname} `;
        str+= `${arr[i].lname} `;
        str+= "knows "
        for(var lang in arr[i].languages){
            if(lang == arr[i].languages.length - 1){
                str += `and ${arr[i].languages[lang]}.`;

            }
            else{
                str += `${arr[i].languages[lang]}, `;
            }
        }
        console.log(str);
        var str2 = `${arr[i].fname} is also interested in `;
        var count = Object.keys(arr[i].interests).length;
        for(var category in arr[i].interests){
            count = count-1;
            for(var interest in arr[i].interests[category]){
                if(count == 0){
                    if(interest == arr[i].interests[category].length - 1){
                        str2 += `and ${arr[i].interests[category][interest]}.`;
                    }
                    else{
                        str2 += `${arr[i].interests[category][interest]}, `;
                    }
                }
                else{
                    str2 += `${arr[i].interests[category][interest]}, `;
                }
            }
        }
        console.log(str2);
    }
}
return userLanguages(users);