function smallestTwoNumbers(arr) {
    arr = arr
        .map(Number)
        .sort(function(a, b){return a-b});
    console.log(`${arr[0]} ${arr[1]}`);
}

smallestTwoNumbers([3, 0, 10, 4, 7, 3]);