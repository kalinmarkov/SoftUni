function orbit(arr) {

    /*
    let rows = arr[0];
    let cols = arr[1];
    let x = arr[2];
    let y = arr[3];
    */

    let [rows, cols, x, y] = arr;
    let matrix = [];

    for (let row = 0; row < rows; row++) {
        matrix[row] = [cols];
        for (let col = 0; col < cols; col++) {
            matrix[row][col] = 0;
        }
    }

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix.length; col++) {
            matrix[row][col] = Math.max(Math.abs(y - row),Math.abs(x - col)) + 1;

        }
    }

    for (let row = 0; row < matrix.length; row++) {
        console.log(matrix[row].join(' '));

    }
}

orbit([5, 5, 2, 2]);