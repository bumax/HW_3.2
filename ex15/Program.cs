using System.Globalization;

Console.WriteLine("Введите день недели: ");
var numberOfWeek = Convert.ToInt32(Console.ReadLine());


if (numberOfWeek > 0 && numberOfWeek < 8 && CultureInfo.CurrentCulture.Name == "ru-RU") // проверяем на валидность ввод и то, что мы в России, т.к. у некоторых стран неделя начинается с воскресенья!
    if (numberOfWeek > 5) // если числа 6 или 7 - то это выходные
        System.Console.WriteLine("Да");
    else
        System.Console.WriteLine("Нет");
else
    System.Console.WriteLine("Ошибка! Дни недели могут принимать значение от 1 до 7 включительно, проверьте ввод, ну или вы не из России");