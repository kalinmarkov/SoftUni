function main(input) {
    let wordPattern = /\b[a-zA-Z0-9_]+\b/g;
    let set = new Set();
    for (let sentence of input) {
        let matches = sentence.match(wordPattern);
        matches.forEach(w => set.add(w.toLowerCase()));
    }
    console.log(Array.from(set.values()).join(", "));
}

main([
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque quis hendrerit dui.',
    'Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla.',
    'Vestibulum dolor diam, dignissim quis varius non, fermentum non felis.',
    'Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut.',
    'Morbi in ipsum varius, pharetra diam vel, mattis arcu.',
    'Integer ac turpis commodo, varius nulla sed, elementum lectus.',
    'Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.'
]);