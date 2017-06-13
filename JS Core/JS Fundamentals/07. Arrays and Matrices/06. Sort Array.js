function sortArray(arr) {

    let sortedArr = arr.sort(function(a, b) {
        a = a.toLowerCase();
        b = b.toLowerCase();
        if( a == b) return 0;
        if( a > b) return 1;
        return -1;
    });

    sortedArr = sortedArr.sort((a, b) => a.length - b.length);

    console.log(sortedArr.join('\n'));

}

sortArray(['test', 'Deny', 'omen', 'Default']);