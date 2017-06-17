function solve(dataRows) {
    let flavorsObj = {};
    let bottlesObj = {};
    for (let dataRow of dataRows) {
        let [juiceName, quantity] = dataRow.split(/\s=>\s/g);
        quantity = Number(quantity);

        if (!flavorsObj.hasOwnProperty(juiceName)) {
            flavorsObj[juiceName] = quantity;
        } else {
            flavorsObj[juiceName] += quantity;
        }
    }

    for (let juiceName in flavorsObj){
        let quantity = flavorsObj[juiceName];
        if (quantity >= 1000) {
            let bottlesCount = Math.floor(quantity / 1000);
            if (!bottlesObj.hasOwnProperty(juiceName)) {
                bottlesObj[juiceName] = bottlesCount;
            } else {
                flavorsObj[juiceName] += bottlesCount;
            }
        }
    }

    for (let juiceName in bottlesObj){
        console.log(`${juiceName} => ${bottlesObj[juiceName]}`)
    }
}

solve(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']);