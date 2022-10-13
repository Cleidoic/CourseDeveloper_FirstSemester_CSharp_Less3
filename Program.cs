/*
Проверка на ввод числа.
"Защита от дурака"
*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    Console.WriteLine($"{message}");
    while(!isCorrect)
    {
        isCorrect = int.TryParse(Console.ReadLine(), out result);

        if(!isCorrect) {
            Console.WriteLine($"Ввели не число или оно слишком большое. Введите корректное число \n");
        }
    }

    return result;
}

/*
Задача 1:
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool Palindrome (int num) {

    bool result = false;
    string str_num = num.ToString();

    for (int i = 0; i < str_num.Length/2; i++)
    {
        if (str_num[i] == str_num[str_num.Length - i - 1])
            result = true;
        else
            result = false;
    }

    return result;

}

Console.WriteLine(Palindrome(GetNumber("Введите число до 9 знаков, чтобы проверить является ли оно палиндромом: ")));

/*
Задача 2:
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Distance (int A_x, int A_y, int A_z, int B_x, int B_y, int B_z) {

    double result = 0;
    result = Math.Sqrt(Math.Pow((A_x - B_x), 2) + 
    Math.Pow((A_y - B_y), 2) + Math.Pow((A_z - B_z), 2));
    return Math.Round(result, 2);

}

Console.WriteLine(Distance(7, -5, 0, 1, -1, 9));

/*
Задача 3:
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void CubeNumber (int num) {

    for (int i = 1; i <= num; i++)
    {
        Console.Write($"| {i * i * i} |");
    }

}

CubeNumber(GetNumber($"Введите число, чтобы вычислить кубы его последовательности: "));