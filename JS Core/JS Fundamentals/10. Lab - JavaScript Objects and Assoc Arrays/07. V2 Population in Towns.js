function townPop(arr) {
    let towns = new Map();
    for (let row of arr){
        let [name, pop] = row.split(' <-> ');
        if (!towns.has(name)) {
            towns.set(name, 0);
        }
        towns.set(name, towns.get(name) + Number(pop));
    }

    [...towns].forEach(([town, pop]) => console.log(`${town} : ${pop}`));
}

townPop([   'Sofia <-> 1200000',
            'Montana <-> 20000',
            'New York <-> 10000000',
            'Sofia <-> 1200000',
            'Washington <-> 2345000',
            'Las Vegas <-> 1000000'
]);