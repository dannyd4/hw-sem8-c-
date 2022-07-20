

int[,] CreateNew2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;

}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

double[] averageColumsNumber(int[,] array)
{
    // int[,] myArray = new int[array.GetLength(0), array.GetLength(1)];

    double[] sum = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum[j] += array[i, j];
            if (i == array.GetLength(0) - 1)
                sum[j] = Math.Round(sum[j] / (i + 1), 1);
        }
    }
    return sum;
}

int[,] poraydokRowsMinMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {

                if (array[i, j] < array[i, j + 1])
                {
                    int max = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = max;

                }
            }
        }

    }
    return array;
}

int[] minSumRow(int[,] array)
{


    int[] sum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];

        }
    }
    return sum;
}

int ArrayMinIndex(int[] array)
{
    int min = array[0];
    int minIndex = 0;
       
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) 
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

void ArrayShow(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}


// test 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
Console.WriteLine("Был создан массив: ");

int[,] myArray = CreateNew2dArray(6, 6, 0, 10);
Show2dArray(myArray);

Console.WriteLine("Массив был преобразован: ");

int[,] correctedArray = poraydokRowsMinMax(myArray);

Show2dArray(correctedArray);
*/

// test 56:  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
/*
Console.WriteLine("Был создан двумерный прямоугольный массив: ");
int[,] myArray = CreateNew2dArray(4, 4, 0, 10);
Show2dArray(myArray);

Console.WriteLine("Программа вычислила сумму чисел в каждой строке: ");
int[] sum = minSumRow(myArray);
ArrayShow(sum);

int minIndex = ArrayMinIndex(sum);
Console.WriteLine("Первая найденная строка с минимальной суммой чисел имеет индекс i = " + minIndex);
*/


// test 62:  Заполните спирально массив 4 на 4.
/*
Console.WriteLine("Заполняем массив по спирали");
 int m = 4;
 int n = 4;
 
 //С помощью переменной s задаются числа внутри массива начиная с 1.
int s = 1;
 
 //Объявляем и инициализируем массив.
int[,] array = new int[m,n];
 
 //Заполняем периметр массива по часовой стрелке.
for (int y = 0; y < n; y++) 
{
     array[0,y] = s;
    s++;
}
for (int x = 1; x < m; x++)
{
    array[x,n - 1] = s;
    s++;
}
for (int y = n - 2; y >= 0; y--) 
{
    array[m - 1,y] = s;
    s++;
}
for (int x = m - 2; x > 0; x--) 
{
    array[x,0] = s;
    s++;
}
 
//Периметр заполнен. Продолжаем заполнять массив и задаём
//координаты ячейки, которую необходимо заполнить следующей.
int c = 1;
int d = 1;
 
while (s < m * n) {
           
//Периметр мы заполнили числами, отличными от нулей.
//Следующие циклы поочерёдно работают, заполняя ячейки.
//Вложенный цикл останавливается, если следующая ячейка имеет 
//значение, отличное от ноля. Ячейка, на которой остановился 
//цикл, не заполняется.
 
//Движемся вправо.
while (array[c,d + 1] == 0) 
{
    array[c,d] = s;
    s++;
    d++;
}
 
//Движемся вниз.
while (array[c + 1,d] == 0) 
{
    array[c,d] = s;
    s++;
    c++;
}
 
//Движемся влево.
while (array[c,d - 1] == 0) 
{
    array[c,d] = s;
    s++;
    d--;
}
 
//Движемся вверх.
while (array[c - 1,d] == 0) 
{
    array[c,d] = s;
    s++;
    c--;
}
}
 
//При данном решении в центре всегда остаётся незаполненная ячейка.
//Убираем её при помощи следующего цикла.
for (int x = 0; x < m; x++) 
{
    for (int y = 0; y < n; y++) 
    {
        if (array[x,y] == 0) 
        {
            array[x,y] = s;
        }
    }
}

Show2dArray(array);
*/