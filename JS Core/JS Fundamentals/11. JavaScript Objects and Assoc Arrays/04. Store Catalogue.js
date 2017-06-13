function main(input) {
    let products = new Map();
    for (let i = 0; i < input.length; i++) {
        let productArgs = input[i].split(":").map(x => x.trim());
        let productName = productArgs[0];
        let productQuantity = Number(productArgs[1]);

        products.set(productName, productQuantity);
    }

    let orderedProduct = Array.from(products.keys()).sort();
    let previousFirstLetter = '';
    for(let p of orderedProduct){
        let firstLetter = p.substr(0,1);
        if(firstLetter != previousFirstLetter){
            console.log(firstLetter);
        }
        console.log(` ${p}: ${products.get(p)}`);
        previousFirstLetter = firstLetter;
    }
}

main([  'Appricot : 20.4',
        'Fridge : 1500',
        'TV : 1499',
         'Deodorant : 10',
      'Boiler : 300',
      'Apple : 1.25',
     'Anti-Bug Spray : 15',
     'T-Shirt : 10'
]);