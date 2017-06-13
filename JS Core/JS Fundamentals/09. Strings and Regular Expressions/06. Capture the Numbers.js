function main(arr) {
    let regex = new RegExp(/[\d]+/g);
    let result = "";
    for (let i = 0; i < arr.length; i++) {

        let temp = "";
        while ((temp = regex.exec(arr[i])) !== null) {
            result += temp + " ";
        }
        ;
    }
    console.log(result);
}

main(['The300', 'What is that?', 'I think it’s the 3rd movie.', 'Lets watch it at 22:45']);