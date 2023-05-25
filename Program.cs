Console.WriteLine("Напишите какое число А вы хотите возвести в степень В ");
int firstNumber, secondNumber;
firstNumber = Convert.ToInt32(Console.ReadLine());
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вот что вышло {exponentiation(firstNumber, secondNumber)}");

int exponentiation(int number, int degree)
{
    int result = number;
    for (int i = 1; i < degree; i++)
    {
        result *= number;
    }
    return result;
}