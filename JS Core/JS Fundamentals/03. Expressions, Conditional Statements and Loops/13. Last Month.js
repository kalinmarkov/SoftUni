function printLastDay(input) {
    let day = input[0];
    let month = input[1];
    let year = input[2];

    let date=new Date(year,month-1,day);

    let curentYear = date.getFullYear();
    let curentMonth = date.getMonth();

    let lastDay = new Date(curentYear, curentMonth,1, 0);

    console.log(lastDay.getUTCDate());
}