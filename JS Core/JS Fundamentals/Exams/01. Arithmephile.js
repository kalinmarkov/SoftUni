function findBiggestProduct(inputArr) {
    inputArr = inputArr.map(Number);
    let biggest = Number.MIN_SAFE_INTEGER;

    for (let i = 0; i < inputArr.length; i++) {

        let currentNumber = inputArr[i];

        if (currentNumber >= 0 && currentNumber < 10) {

            let currentProduct = 1;
            for (let j = i + 1; j <= i + currentNumber; j++) {
                let currentMultiplier = inputArr[j];
                currentProduct *= currentMultiplier;

                if (currentProduct > biggest) {
                    biggest = currentProduct;
                }
            }
        }
    }

    console.log(biggest);
}

findBiggestProduct([
    10,
    20,
    2,
    30,
    44,
    3,
    56,
    20,
    24
]);