function minMaxAvg(arr){
    var min = Math.min.apply(null, arr);
    var max = Math.max.apply(null, arr);
    var sum = 0;
    for(var i = 0; i < arr.length; i++){
        sum+=arr[i];
    }
    avg = sum/arr.length;
    console.log(`The Minimum is ${min}, the Maximum is ${max}, the Average is ${avg}.`);
}
minMaxAvg([1,-2,9,4]);