let calculateData = require('../models/Calculator');

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) => {

        let calculatorParams = req.body['calculator'];

        let calculator = new calculateData(
            Number(calculatorParams.leftOperand),
            calculatorParams.operator,
            Number(calculatorParams.rightOperand)
        );

        let result = calculator.calculateResult();

        res.render('home/index', {'calculator': calculator, 'result': result});
    }
};