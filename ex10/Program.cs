/* 
// Читерский метод =)

Console.WriteLine("Введите трехзначное число: ");
var number = Console.ReadLine();

System.Console.WriteLine("Второе число: {0}", number[1]); */


Console.WriteLine("Введите трехзначное число: ");
var number = Convert.ToUInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    var secondDigit = (number - (number / 100 * 100 + number % 10)) / 10;

    System.Console.WriteLine("Второе число: {0}", secondDigit);
}
else
    System.Console.WriteLine("Это число не трехзначное!");