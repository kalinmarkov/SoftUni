using System;

class Program
{
    private static void Main()
    {
        //  Програма, за сортиране на имена, по вече зададен масив от разбъркани имена

        //  Създаваме масив от стрингове с готов набор от имена зададени в разбъркан ред
        string[] names =
            {
                "Ivan",
                "Ani",
                "Georgi",
                "Todor",
                "Venci",
                "Milen",
                "Maria",
                "Ivailo",
                "Svetla",
                "Petar"
            };

        //  Извикваме готова функция за масиви и сортираме масива по азбучен ред
        Array.Sort(names);

        //  Запазваме в променлива стринг, готовия за разпечатване масив. Всяко име на нов ред
        string result = string.Join(Environment.NewLine, names);

        //  Разпечатваме резултата
        Console.WriteLine(result);
    }
}
