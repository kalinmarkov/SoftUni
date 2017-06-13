function printArrayWithDelimiter(arr) {
    let delimiter = arr[arr.length-1];
    arr = arr.splice(0,arr.length-1);
    console.log(arr.join(delimiter));
}

printArrayWithDelimiter(['One', 'Two', 'Three', 'Four', 'Five', '-']);