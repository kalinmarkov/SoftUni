function main(arr){
    let firstNum = Number(arr[0]);
    let lastNum = Number(arr[arr.length-1]);
    function calcSum(firsNum, secondNum) {
        return firsNum + secondNum;
    }

    let sum = calcSum(firstNum,lastNum);
    console.log(sum);
}