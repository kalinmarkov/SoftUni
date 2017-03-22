function findSumInNumbers(args) {
    let numbers = args[0].split(' ').map(Number);
    let a = numbers[0];
    let b = numbers[1];
    let c = numbers[2];

    if (a + b == c){
        if (a > b){
            console.log(`${b} + ${a} = ${c}`);
        }
        else {
            console.log(`${a} + ${b} = ${c}`);
        }
    }
    else if (a + c == b){
        if (c > a){
            console.log(`${a} + ${c} = ${b}`);
        }
        else {
            console.log(`${c} + ${a} = ${b}`);
        }
    }
    else if (b + c == a){
        if (b > c){
            console.log(`${c} + ${b} = ${a}`);
        }
        else {
            console.log(`${b} + ${c} = ${a}`);
        }
    }
    else {
        console.log('No');
    }

}

findSumInNumbers(['8 15 7'])
