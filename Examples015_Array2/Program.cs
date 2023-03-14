/* Двумерные массивы 

string[,] table = new string[2,3];  // таблица из строк , 
[2,3]-[строки, столбцы]
 
int[,] matrix = new int[5,8];      // таблица чисел(матрица)
[строки matrix.GetLength(0), столбцы matrix.GetLength(0)]

*/

string[,] table = new string[2,5];
//Srting.Empty - инициализация для строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

// table[1,2] = "word";        //обращение к нужному элементу
// for (int rows = 0; rows < 2; rows++)  // rows - строки
// {
//     for (int columns = 0; columns < 5; columns++)// columns - столбцы
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void PrintArray(int[,] matr)  // метод печати двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 означает строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 означает столбцы
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)  // метод заполнения двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 означает строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 означает столбцы
        {
            matr[i,j] = new Random().Next(1,10); //[1;10)
        }
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);