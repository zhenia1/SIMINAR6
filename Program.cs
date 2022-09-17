// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число:");
string numbers = Console.ReadLine();
//нам нужно перебрать каждый элемент строки,если это не запятая или пробел,кладм его в массив,если запятая или пробеле.делаем ++
string[] newNumbers = new string[numbers.Length];
int b = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        b++;
    }
    else
    {
        newNumbers[b] = newNumbers[b] + $"{numbers[i]}";

    }
}
b++;
int[] resultNumbers = new int[b];
PrintArray(resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < b; i++)
{
    if (resultNumbers[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine("Количество чисел больше 0:" + sum);

void PrintArray(int[] array, string[] string1)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(string1[i]);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


