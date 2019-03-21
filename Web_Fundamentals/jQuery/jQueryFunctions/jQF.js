$(document).ready(function(){
    $("h1").click(function(){
        $(this).addClass("red");
    });
    $(".body").click(function(){
        $(".body p").fadeIn("slow",function(){
        });
    });
    $("p").click(function(){
         $(this).fadeOut("fast");
    });
    $("button").click(function(){
        $(".para").append("<p>Answers answers answers answers...............</p><hr>")
    });
    $("input").click(function(){
        $("input").val("Skylar")
    })    
});