/*
function argumentInfo() {
    let typeCounts = {};
    for(let arg of arguments){
        console.log(`${typeof(arg)}: ${arg}`);
        if(! typeCounts[typeof(arg)]){
            typeCounts[typeof(arg)] = 1;
        } else {
            typeCounts[typeof(arg)]++;
        }
    }

    Object.keys(typeCounts).sort((a, b) => typeCounts[b] - typeCounts[a]).forEach(k => console.log(`${k} = ${typeCounts[k]}`))
}*/


function result() {
    let argumentTypes = {};

    for (let i = 0; i < arguments.length; i++) {
        let argumentValue = arguments[i];
        console.log(`${typeof argumentValue}: ${argumentValue}`);

        if (!argumentTypes.hasOwnProperty(typeof argumentValue)) {
            argumentTypes[typeof argumentValue] = 0;
        }

        argumentTypes[typeof argumentValue]++;
    }

    let sortedArray = [];

    for (let argumentType in argumentTypes){
        if (argumentTypes.hasOwnProperty(argumentType)) {
            let element = argumentTypes[argumentType];
            sortedArray.push([argumentType, element]);
        }
    }
    
    sortedArray = sortedArray.sort((a,b) => {
        "use strict";
        return b[1] - a[1];
    });
    
    for (let i = 0; i < sortedArray.length; i++) {
        let element = sortedArray[i];
        let argumentType = element[0];
        let argumentCount = element[1];

        console.log(`${argumentType} = ${argumentCount}`);
    }
}


result('cat', 42, 324, function () { console.log('Hello world!'); });