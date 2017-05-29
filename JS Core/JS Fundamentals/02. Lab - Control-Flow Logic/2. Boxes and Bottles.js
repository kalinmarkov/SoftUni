function boxesToFit(a, b) {
    let numberOfBottles = Number(a);
    let boxCapacity = Number(b);
    let neededBoxes = Math.ceil(numberOfBottles/boxCapacity);
    console.log(neededBoxes);
}

boxesToFit(15, 7);