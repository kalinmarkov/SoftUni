function decodeMessage(input) {
    let templateMatrixSide = Number(input[0]);
    let templateMatrix = [];
    for (let i = 1; i < 1 + templateMatrixSide; i++) {
        let currentRow = input[i];
        templateMatrix.push(currentRow.split(' ').map(Number))
    }

    let encodedMatrix = [];
    for (let i = 1 + templateMatrixSide; i < input.length; i++) {
        let currentRow = input[i];
        encodedMatrix.push(currentRow.split(' ').map(Number))
    }

    let tempMatrixRow = templateMatrixSide;
    let tempMatrixCol = templateMatrix[0].length;

    for (let encodedRow = 0; encodedRow < encodedMatrix.length; encodedRow += tempMatrixRow) {
        let currentRow = encodedMatrix[encodedRow];
        
        for (let encodedCol = 0; encodedCol < encodedMatrix[encodedRow].length; encodedCol += tempMatrixCol) {
            let currentEncodedNumber = encodedMatrix[encodedRow][encodedCol];
            
            for (let tempRow = 0; tempRow < templateMatrix.length; tempRow++) {
                let currentTempRow = templateMatrix[tempRow];
                
                for (let tempCol = 0; tempCol < templateMatrix[tempRow].length; tempCol++) {
                    let currentTempNumber = templateMatrix[tempRow][tempCol];

                    let targetRow = encodedRow + tempRow;
                    let targetCol = encodedCol + tempCol;
                    
                    if (targetCol < encodedMatrix[encodedRow].length && targetRow < encodedMatrix.length) {
                        let sumNumber = encodedMatrix[targetRow][targetCol] + templateMatrix[tempRow][tempCol];
                        sumNumber %= 27;
                        
                        if (sumNumber === 0) {
                            encodedMatrix[targetRow][targetCol] = ' ';
                        } else {
                            encodedMatrix[targetRow][targetCol] = String.fromCharCode(sumNumber + 64);
                        }
                    }
                }
            }
        }
    }

    let output = '';
    encodedMatrix.forEach(function (element) {
        element.forEach(function (letter) {
            output += letter;
        })
    });

    console.log(output.trim());
}

decodeMessage([ '2',
    '59 36',
    '82 52',
    '4 18 25 19 8',
    '4 2 8 2 18',
    '23 14 22 0 22',
    '2 17 13 19 20',
    '0 9 0 22 22' ]
);