function printTriangleOfDollars(n) {
    let result='';
    
    for (let row = 1; row <= n ; row++) {
        
        for (let col = 1; col <= row; col++) {
            result+="$";
        }
        console.log(result);
        result='';
    }
}