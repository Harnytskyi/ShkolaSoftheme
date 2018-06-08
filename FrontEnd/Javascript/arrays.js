var numbers = [5, 10, 15, 20, 30, 40, 50, 60, 83, 61];

function filterArray(numbers, min, max) {
        var minmaxarr = [];
        var j = 0;
        for (var i = 0; i < numbers.length; i++) {
                if (numbers[i] >= min && numbers[i] <= max) {
                        minmaxarr[j] = numbers[i];
                        j++;
                }
        }
        console.log(minmaxarr);
};
var result = filterArray(numbers, 34, 60);

function checkEmpty(obj) {
        if (Object.keys(obj).length == 0)
                return true;
        else
                return false;
}
var obj2 = {};
console.log(checkEmpty(obj2))

var obj3 = {
        R: 255, G: 0, B: 255
};
function keys2arr(obj) {
        var keysarr = [];
        keysarr = Object.keys(obj);
        return keysarr;
}
console.log(keys2arr(obj3));
