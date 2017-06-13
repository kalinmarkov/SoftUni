function splitStringWithDelimiter(text, delimiter) {
    let result = text.split(delimiter);
    for (let i = 0; i < result.length; i++){
        console.log(result[i]);
    }

}

splitStringWithDelimiter('One-Two-Three-Four-Five', '-');