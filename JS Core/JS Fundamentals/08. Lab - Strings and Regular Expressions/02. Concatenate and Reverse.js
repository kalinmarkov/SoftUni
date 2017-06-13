function concatAndReverce(inputArr) {
    let result = inputArr.join('').split("").reverse().join("");

    console.log(result);

}

concatAndReverce(['I', 'am', 'student']);