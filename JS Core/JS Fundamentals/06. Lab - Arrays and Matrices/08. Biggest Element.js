function biggestElement(matrix) {

    let biggestNum = Number.NEGATIVE_INFINITY;

    matrix.forEach(
        r => r.forEach(
            c => biggestNum = Math.max(biggestNum, c)));

    console.log(biggestNum);
}

biggestElement([[3, 5, 7, 12],
                [-1, 4, 33, 2],
                [8, 3, 0, 4]]);