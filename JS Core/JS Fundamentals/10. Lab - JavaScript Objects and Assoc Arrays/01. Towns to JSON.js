function main(inputArr) {
    let townsArgs = inputArr.slice(1);
    let towns = [];
    for(let i = 0; i < townsArgs.length; i++){
        let currentTown = {};
        let townArgs = townsArgs[i].split(/\s*\|\s*/g).filter(t => t != "");
        currentTown = {
            'Town': townArgs[0],
            "Latitude": Number(townArgs[1]),
            "Longitude": Number(townArgs[2])
        };
        towns.push(currentTown);
    }
    let townsInJason = JSON.stringify(towns);
    console.log(townsInJason);
}

main(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
);