var numbers = [5, 10,15,20,30,40,50,60,83,61];

function filterArray(numbers, min, max) {
        var minmaxarr = [];
        minmaxarr = numbers.filter(i => i >= min && i <= max)
        console.log(minmaxarr);    
};
var result = filterArray(numbers, 34, 60);