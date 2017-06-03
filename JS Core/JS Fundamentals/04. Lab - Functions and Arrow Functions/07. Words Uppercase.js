function printUppercaseWords(inputArr) {
    //75/100
    let words = inputArr.replace(/[!.<>/\,?':"`;]/g," ");
    let newWords = '';
    for (let i = 0; i < words.length; i++) {
        if (words[i] >= 'a' && words[i] <= 'z' || words[i] >= 'A'&& words[i] <= 'Z'){
            newWords += words[i];
        }else if(words[i] == ' ' && words[i+1] != ' ' && i < words.length-1){
            newWords += ", ";
        }else if(words[i] == ' ' && words[i+1] == ' '){
            continue;
        }

    }

    console.log(newWords.toUpperCase().trim());
}

printUppercaseWords('HI,   how   are you?');