function uniqWords(arr) {
    let unique = new Set();
    let text = arr.join('\n');
    let words = text.split(/\W+/)
        .filter(x => x !== '')
        .map(x => x.toLowerCase())
        .forEach(x => unique.add(x));

    console.log([...unique].join(', '));
}

uniqWords([
    'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque quis hendrerit dui.',
    'Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla.',
    'Vestibulum dolor diam, dignissim quis varius non, fermentum non felis.',
    'Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut.',
    'Morbi in ipsum varius, pharetra diam vel, mattis arcu.',
    'Integer ac turpis commodo, varius nulla sed, elementum lectus.',
    'Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.'
]);