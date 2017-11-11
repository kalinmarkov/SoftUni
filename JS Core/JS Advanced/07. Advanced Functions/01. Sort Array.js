/*function sortArray(array, method) {
    let ascendingComparator = (a, b) => a-b;
    let descendingComparator = (a, b) => b-a;

    let sortingStrategies = {
        asc: ascendingComparator,
        desc: descendingComparator
    };

    return array.sort(sortingStrategies[method]);
}*/


function sortArray(array, orderType) {
    if (orderType === 'asc') {
    return array.sort((a, b) => {
        "use strict";
        return a - b
    });
    } else {
    return array.sort((a, b) => {
        "use strict";
        return b - a
    });
    }
}

console.log(sortArray([14, 7, 17, 6, 8], 'desc'));