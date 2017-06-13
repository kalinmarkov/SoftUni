function main(arr) {
    let result = arr
        .filter((x, i) => Math.trunc(i % 2 != 0))
        .map(x => x * 2)
        .reverse();
    console.log(result);
}