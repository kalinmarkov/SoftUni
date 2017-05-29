function circleArea(r) {
    let circleArea = Math.PI * r * r;
    console.log(circleArea);

    let roundedArea = Math.round(circleArea * 100) / 100;
    // let roundedArea = circleArea.toFixed(2);
    console.log(roundedArea);
}

circleArea(5);