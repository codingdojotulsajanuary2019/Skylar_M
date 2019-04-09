function coinChange(val){
    var dollars = 0;
    var quarters = 0;
    var dimes = 0;
    var nickels = 0;
    var pennies = 0;
    while(val > 100){
        val-=100;
        dollars++;
    }
    while(val > 25){
        val-=25;
        quarters++;
    }
    while(val > 10){
        val-=10;
        dimes++;
    }
    while(val > 5){
        val-=5;
        nickels++;
    }
    pennies = val;
    return(`Dollars: ${dollars}, Quarters: ${quarters}, Dimes: ${dimes}, Nickels: ${nickels}, Pennies: ${pennies}`)
}
console.log(coinChange(347));