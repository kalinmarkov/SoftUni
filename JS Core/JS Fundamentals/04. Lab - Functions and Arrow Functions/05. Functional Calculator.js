function calculator(firstNum, secondNum, operator) {
    if (operator == "+"){
        console.log(firstNum + secondNum);
    }else if(operator == "-"){
        console.log(Math.abs(firstNum - secondNum));
    }else if(operator == "*"){
        console.log(firstNum * secondNum);
    }else if(operator == "/"){
        console.log(firstNum / secondNum);
    }else if(operator == "%"){
        console.log(firstNum % secondNum);
    }
}

calculator(2, 3, "+");