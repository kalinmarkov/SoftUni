function  main(arr) {
    let oddElements = arr.filter((x, i) => i % 2 == 0);
    console.log(oddElements.join(" "));
}