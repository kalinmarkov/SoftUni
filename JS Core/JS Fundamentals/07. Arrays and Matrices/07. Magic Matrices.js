function magicMatrices(arr) {
    let matrix = [];
    for (let row = 0; row < arr.length; row++) {
        matrix[row] = arr[row].map(Number);
    }

    let magicSum = 0;
    let isMagicMatrix = true;
    for (let row = 0; row < arr.length; row++) {
        let rowSum = 0;
        let colSum = 0;
        for (let col = 0; col < arr[row].length; col++) {
            rowSum += matrix[row][col];
            colSum += matrix[col][row];
        }

        if(magicSum != rowSum && row > 0){
            isMagicMatrix = false;
            break;
        }

        if(magicSum != colSum && row > 0){
            isMagicMatrix = false;
            break;
        }
        magicSum = rowSum;

    }
    console.log(isMagicMatrix)
}

magicMatrices([['4', '5', '6'],
               ['6', '5', '4'],
               ['5', '5', '5']]);