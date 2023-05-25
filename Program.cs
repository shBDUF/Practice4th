// Console.WriteLine("Напишите какое число А вы хотите возвести в степень В ");
// int firstNumber, secondNumber;
// firstNumber = Convert.ToInt32(Console.ReadLine());
// secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вот что вышло {exponentiation(firstNumber, secondNumber)}");

// int exponentiation(int number, int degree)
// {
//     int result = number;
//     for (int i = 1; i < degree; i++)
//     {
//         result *= number;
//     }
//     return result;
// }

// Console.WriteLine("Напишите число ");
// int Number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" сумма цифр в числе {0} равна {1}", Number, SumOfDigit(Number));
// int SumOfDigit(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
//     return result;
// }
Console.WriteLine("Введите размерность массива: ");
Random rnd = new Random();
int lenghtOfArray = Convert.ToInt32(Console.ReadLine());
int[] array =new int[lenghtOfArray];
for (int i = 0; i < lenghtOfArray; i++)
{
    array[i]= rnd.Next(0,100);
}
for (int i = 0; i < lenghtOfArray; i++)
{
    Console.WriteLine($"{i} эллемент массива = {array[i]}");
}
