/*  Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  */

int numberOfPositiveElements = 0;
int lenght = GetNumber("Enter amount of your numbers:", true);
int[] arrayOfNumbers = new int[lenght];


int GetNumberAndCountPositive(string message, bool natural)
{
    bool isCorrect = false;
    int result = 0;


    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (natural == true)
        {
            if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            {
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Error: wrong entered data.");
            }
        }
        else
        {
            if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            {
                isCorrect = true;
                numberOfPositiveElements++;
            }
            else if (result <= 0)
            {
                isCorrect = true;                
            }
            else
            {
                Console.WriteLine("Error: wrong entered data. Try again.");
            }
        }
    }
    return result;
}

int[] GetArray(string message)
{
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        arrayOfNumbers[i] = GetNumber($"{message} {i + 1}:", false);
    }
    return arrayOfNumbers;
}


arrayOfNumbers = GetArray("Enter element");
Console.WriteLine($"You entered {numberOfPositiveElements} positive numbers.");


