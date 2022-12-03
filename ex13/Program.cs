Console.WriteLine("Введите число: ");
string numberString = Console.ReadLine();

int len = numberString.Length;

var number = Convert.ToInt32(numberString);

if (len > 2)
{
    // смещаем число вправо так, чтобы "третья" цифра находилась на позиции единиц
    var thirdDigit = (number / (int)(Math.Pow(10, len - 3))) % 10;
    System.Console.WriteLine("Третья цифра: {0}", thirdDigit);

}

else
    System.Console.WriteLine("третьей цифры нет");