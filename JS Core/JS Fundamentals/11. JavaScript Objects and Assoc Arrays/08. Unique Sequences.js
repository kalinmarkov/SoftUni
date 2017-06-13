function main(input) {
    let seqs = new Set();
    for(let row of input) {
        let arr = JSON.parse(row).map(Number).sort((a, b) => b - a);
        let arrayToAdd = `[${arr.join(', ')}]`;
        seqs.add(arrayToAdd);
    }
    let result = Array.from(seqs)
        .sort((a,b) =>a.split(', ').length - b.split(', ').length);

    result.forEach(arr => console.log(arr));
}

main([
    '[-3, -2, -1, 0, 1, 2, 3, 4]',
    '[10, 1, -17, 0, 2, 13]',
   '[4, -3, 3, -2, 2, -1, 1, 0]'
]);