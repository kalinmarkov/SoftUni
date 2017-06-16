function matchManipulation(inputElement) {
    let regex = new RegExp(/\b([\-]*[\d]+)[\s]*\*[\s]*([\-]*[\d]+[\.]*[\d]+)\b/);
    let match;
    while (match = regex.exec(inputElement)){
        let firstNumber = Number(match[1]);
        let secondNumber = Number(match[2]);
        let result = firstNumber * secondNumber;
        inputElement = inputElement.replace(match[0],result);
    }
    console.log(inputElement);

}

matchManipulation(`My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).`);