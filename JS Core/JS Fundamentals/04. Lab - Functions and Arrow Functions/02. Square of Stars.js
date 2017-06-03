function printSquareOfStar(count) {
    
    function printStars(n = count) {
        console.log('*' + ' *'.repeat(n-1));
    }
    for (let i = 1; i <= count ; i++) {
        printStars()
    }
}

console.log(printSquareOfStar(5));