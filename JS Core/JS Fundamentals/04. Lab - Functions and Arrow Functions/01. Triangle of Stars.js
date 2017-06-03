function printTrangleOfStars(n) {
    for (let row = 1; row <=n; row++) {
        let result='';
        for (let col = 1; col <=row ; col++) {
            result+="*"
        }
        console.log(result);
    }

    for (let row = n-1; row >= 1; row--) {
        let result="";
        for (let col = row; col >=1 ; col--) {
            result+="*";
        }
        console.log(result);
    }
}