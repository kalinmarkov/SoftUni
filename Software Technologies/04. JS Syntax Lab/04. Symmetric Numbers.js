function symmetricNumbers(args) {
    let n = Number(args[0]);
    let result = '';

    for (let i = 1; i <= n; i++){
        if (i < 10){
            result += `${i} `;
        }
        else {
            let str = i.toString();
            let isSymmetric = true;

            for (let j = 0; j < str.length / 2; j++) {

                if (str[j] !== str[str.length - j - 1]) {
                    isSymmetric = false;
                    break;
                }

            }

            if (isSymmetric){
                result += `${i} `;
            }
        }
    }

    console.log(result)
}

args = ['100'];

