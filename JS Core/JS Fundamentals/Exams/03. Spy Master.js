function decodeMessages(inputStrings) {
    let specialKey = inputStrings[0];
    let pattern = `(\\s|^)(${specialKey})\\s+([!#?%A-Z]{8,})(\\.|,|\\s|$)`;
    let rgx = new RegExp(pattern, 'gi');

    for (let i = 0; i < inputStrings.length; i++) {
        let currentString = inputStrings[i];
        let match;
        while (match = rgx.exec(currentString)) {
            console.log(match);
            let encodedWord = match[3];

            if (encodedWord.toUpperCase() !== encodedWord) {
                continue;
            }

            let decodedWord = decodeWord(encodedWord);
            console.log(decodedWord)
        }


    }

    function decodeWord(encodedWord) {
        while (encodedWord.indexOf('!' !== -1)) {
            encodedWord = encodedWord.replace('!', '1');
        }

        while (encodedWord.indexOf('%' !== -1)) {
            encodedWord = encodedWord.replace('%', '2');
        }

        while (encodedWord.indexOf('#' !== -1)) {
            encodedWord = encodedWord.replace('#', '3');
        }

        while (encodedWord.indexOf('$' !== -1)) {
            encodedWord = encodedWord.replace('$', '4');
        }
    }
}

decodeMessages([`specialKey`,
                `In this text the specialKey HELLOWORLD! is correct, but
                the following specialKey $HelloWorl#d and spEcIaLKEy HOLLOWORLD1 are not, while
                SpeCIaLkeY   SOM%%ETH$IN and SPECIALKEY ##$$##$$ are!`
]);