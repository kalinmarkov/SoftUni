function numbers(n) {
    let num = Number(n);
    let str = '';
    for (let i=1; i<= num; i++) {
        str += i;
    }
    return str;
}

numbers('11');
