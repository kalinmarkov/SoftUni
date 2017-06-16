function employeeData(input) {
    let regex = /(^[A-Z][A-Za-z]*) - ([1-9]+[0-9]*) - ([A-Za-z\d \-]+)$/;

    for (let element of input) {

        let match = regex.exec(element);

        if (match === null) {
            continue;
        }

        console.log(`Name: ${match[1]}`);
        console.log(`Position: ${match[3]}`);
        console.log(`Salary: ${match[2]}`);
    }

}

employeeData(['Isacc - 1000 - CEO'],
            ['Ivan - 500 - Employee'],
            ['Peter - 500 - Employee'],
            ['Jonathan - 2000 - Manager'],
            ['Peter- 1000- Chuck'],
            ['George - 1000 - Team Leader'],
            ['Jonathan - 2000 - Manager'],
            ['Iv - 1000 - Chuck'],
            ['george - 1000 - Team Leader']);