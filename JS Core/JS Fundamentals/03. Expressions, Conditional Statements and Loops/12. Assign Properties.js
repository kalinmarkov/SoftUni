function printObject(input) {
    let firstValue = input[0];
    let secondValue = input[2];
    let thirdValue = input[4];

    console.log({
        [firstValue]: input[1],
        [secondValue]: input[3],
        [thirdValue]: input[5]
    });
}