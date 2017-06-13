function countOccurences(pattern, text) {
    let countOccurrences = 0;

    let lastIndex = -1;
    while (true){
        lastIndex = text.indexOf(pattern, lastIndex);
        if(lastIndex < 0){
            break;
        }
        lastIndex++;
        countOccurrences++;
    }
    console.log(countOccurrences);

}

countOccurences('the', 'The quick brown fox jumps over the lay dog.');