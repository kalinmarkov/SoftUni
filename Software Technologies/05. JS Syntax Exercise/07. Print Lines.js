function solve(args){
    for(let line of args) {
        if(line === 'Stop'){
            break;
        }
        console.log(line);
    }
}

solve([
    '1',
    '2',
    '3',
    'Stop',
    '4',
    '5'
])