$(document).ready(function(){
    // $.get()
    // $.post()
    for(var i = 1; i < 152; i++){
        $('div.all_poke').append(`<img id=${i} src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${i}.png" alt='pokemon'>`);
        
        /* $.ajax({
            method: 'get',
            url: 'https://pokeapi.co/api/v2/pokemon/'+i,
            // data: send post data
            dataType: 'json',
            success: function(res) {
                // get the info form the request
                console.log(res);
                $('div.all_poke').append(`<img id=${i} src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${i}.png" alt='pokemon'>`);
            },
            error: function(err) {
                // server error
            },
            complete: function(next) {
                // regardless of success or error, this will run
                console.log('in done method');
            }
        })
        console.log('after the ajax method'); */
    }

})