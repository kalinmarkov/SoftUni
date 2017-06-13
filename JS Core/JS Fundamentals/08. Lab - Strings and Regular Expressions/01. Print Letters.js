function printLetters(input) {
    let text = input;

    for (let i = 0; i < text.length; i++) {
        console.log(`str[${i}] -> ${text[i]}`);

    }

}

printLetters('Hello, World!');