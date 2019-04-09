$(document).ready(function(){
    $.get("https://opentdb.com/api.php?amount=10&category=12&type=multiple", function(data){
        console.log(data);
        var i = 0;
        function displayQuestion(){
            var question = data.results[i].question;
            $("#question").html(question);
        }
        function displayAnswers(){
            var answerArr = data.results[i].incorrect_answers;
            answerArr.push(data.results[i].correct_answer);
            console.log(answerArr);
            while(answerArr.length > 0){
                var n = answerArr.length;
                var rand = Math.floor(Math.random() * n);
                var temp = answerArr[rand];
                answerArr[rand] = answerArr[n-1];
                answerArr[n-1] = temp;
                var answer = answerArr.pop();
                console.log(answer);
                $("#answers").append(`<div class="answers" style=""><button class="light-green accent-4 btn-small" value="${answer}"><i class="material-icons">graphic_eq</i></button><h5 style="display:inline-block; margin-left:1rem;">${answer}</h5></div><br class="answers">`);
            }
        }
        displayQuestion();
        displayAnswers();
        $("#next").click(function(){
            if(i<data.results.length){
                $(".answers").remove();
                i = i+1;
                console.log(i);
                displayQuestion();
                displayAnswers();
            }
        })
        console.log(i);
    })
})