function roundingNum(input) {
    let roundedNumber = Number(input[0]);
    let precision = Number(input[1]);
    if (precision > 15) {
        precision = 15;
    }
    let result = roundedNumber.toFixed(precision);
    result = parseFloat(result);
    console.log(result);
}