// Змейка усложненная
using System.Xml.XPath;
Console.Write("Введите номер столбца(от 1 до 106): "); //4
int N = Convert.ToInt32(Console.ReadLine());
int ada;
int result;
if (N > 106 || N < 1)
{
    Console.WriteLine("Число не соответствует диапазону. Попробуйте ввести его ещё раз.");
}
else
{

    ada = (N * N + 1) / 2;//Формула расчёта чисел в средней линии
    result = (ada - 1) / 9 * 10 + (ada - 1) % 9 + 1;//Формула расчёта с учётом сдвига
    Console.WriteLine($"Был выбран столбец {N}. Число в средней строке {result}");


    int[,] massiv = new int[N + 2, N + 1]; //Начало выовда массива в зависимости от введённого пользователем числа

    int counter = N * N; //ПОСЛЕДНЕЕ ЧИСЛО
    int start_point = (N + 2) / 2;

    int i = 2; //это для сравнения с последним числом змейки
    int column = 1;
    int row = (N + 2) / 2;

    massiv[start_point, 0] = 1; //записали 1;

    while (i < counter)
    {
        if (column % 2 == 0) //четный столбец
        {
            for (int c = 0; c < column + 1; i++, c++, row--)
            {
                massiv[row, column] = i;
            }
            row++;
        }

        else if (column % 2 != 0) //нечетный столбец
        {
            for (int c = 0; c < column + 1; i++, c++, row++)
            {
                massiv[row, column] = i;
            }
            row--;
        }
        column++; //перешли к след столбцу
    }

    for (int d = 0; d < N + 2; d++)
    {
        for (int k = 0; k < N + 1; k++)
        {
            Console.Write(massiv[d, k] + " ");
        }
        Console.WriteLine();
    }
}

Console.ReadKey();