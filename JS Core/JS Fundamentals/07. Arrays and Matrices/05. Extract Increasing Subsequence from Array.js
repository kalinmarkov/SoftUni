function increasingSequence(input) {
    input = input.map(Number);
    let arr = [];
    let biggest;
    input.forEach(function(e){
        if (biggest != undefined){
            if (e >= biggest){
                arr.push(e);
                biggest = e;
            }
        }
        else{
            biggest = e;
            arr.push(e);
        }
    });
    arr.forEach(e => console.log(e));


}

increasingSequence(['1', '2', '3', '4', '6', '1', '2', '3', '4', '6']);