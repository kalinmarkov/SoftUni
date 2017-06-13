function dnaHelix(n) {
    let sequence = 'ATCGTTAGGG';
    let seqLength = sequence.length;
    let index = -1;
    for (let i = 1; i <= n; i++){
        index = getIndex(++index, seqLength);
        let firstSymbol = sequence.charAt(index);
        index = getIndex(++index, seqLength);
        let secondSymbol = sequence.charAt(index);

        if (i % 4 === 1) {
            console.log(`**${firstSymbol}${secondSymbol}**`);
        } else if (i % 4 === 2 || i % 4 === 0) {
            console.log(`*${firstSymbol}--${secondSymbol}*`);
        } else {
            console.log(`${firstSymbol}----${secondSymbol}`);
        }
    }

    function getIndex(index, len) {
        if (index >= len) {
            index = 0;

        }

        return index;
    }
}

dnaHelix(15);