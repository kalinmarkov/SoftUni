function calculateDistance(arr) {
    firstSpeed = Number(arr[0]);
    secondSpeed = Number(arr[1]);
    timeInSecond = Number(arr[2]);

    firstSpeed = firstSpeed * (1000/3600);
    secondSpeed = secondSpeed * (1000/3600);

    let firstDistance = firstSpeed * timeInSecond;
    let secondDistance = secondSpeed * timeInSecond;

    let distance = Math.abs(firstDistance - secondDistance);

    console.log(distance);
}

calculateDistance(5, -5, 40);