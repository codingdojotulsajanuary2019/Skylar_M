function bracesValid(str){
    var count = 0;
    for(var i = 0; i < str.length; i++){
        if(str[i] == "(" || str[i] == "{" || str[i] == "["){
            count++;
            continue;
        }
        else if(str[i] == ")"){
            if(str[i-1] == "("){
                var temp=count;
                count--;
                while(count>0){
                    var n = 1;
                    if(str[i+n] == ")"){
                        if(str[i-n-1] == "(")
                        count--;
                        n++;
                    }
                    else if(str[i+n] == "]"){
                        if(str[i-n-1] == "[")
                        count--;
                        n++;
                    }
                    else if(str[i+n] == "}"){
                        if(str[i-n-1] == "{")
                        count--;
                        n++;
                    }
                    else{return false;}
                }
                i+=temp-1;
            }
            else{return false;}
        }
        else if(str[i] == "]"){
            if(str[i-1] == "["){
                var temp=count;
                count--;
                while(count>0){
                    var n = 1;
                    if(str[i+n] == ")"){
                        if(str[i-n-1] == "(")
                        count--;
                        n++;
                    }
                    else if(str[i+n] == "]"){
                        if(str[i-n-1] == "[")
                        count--;
                        n++;
                    }
                    else if(str[i+n] == "}"){
                        if(str[i-n-1] == "{")
                        count--;
                        n++;
                    }
                    else{return false;}
                }
                i+=temp-1;
            }
            else{return false;}
        }
        else if(str[i] == "}"){
            if(str[i-1] == "{"){
                var temp=count;
                count--;
                while(count>0){
                    var n = 1;
                    if(str[i+n] == ")"){
                        if(str[i-n-1] == "(")
                        count--;
                        n++;
                    }
                    else if(str[i+n] == "]"){
                        if(str[i-n-1] == "[")
                        count--;
                        n++;
                    }
                    else if(str[i+n] == "}"){
                        if(str[i-n-1] == "{")
                        count--;
                        n++;
                    }
                    else{return false;}
                }
                i+=temp-1;
            }
            else{return false;}
        }
    }
    return true;
}
console.log(bracesValid("{{{()}}}[[]]()"));