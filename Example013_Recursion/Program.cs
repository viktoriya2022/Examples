string[,] table = new string[2, 5];
// // String.Empty
// // table[0,0]   table[0,1]   table[0,2]   table[0,3]   table[0,4] 
// // table[1,0]   table[1,1]   table[1,2]   table[1,3]   table[1,4]

// //обращаемся к нужному элементу
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0) где 0-позиция аргумента строки :3
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //matrix.GetLength(0) где 1-позиция аргумента строки :4
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0) где 0-позиция аргумента строки :3. Возвращает коло-во строк в массиве
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //matrix.GetLength(0) где 1-позиция аргумента строки :4. Возвращает коло-во столбцов в массиве
//         {
//             matr[i, j] = new Random().Next(1, 10); // [1;10)
//         }

//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


//============== рекурсия факториал ==========

double Factorial (int n)
{
    //1!=1
    //0!=1
    if (n==1) return 1;
    else return  n*Factorial(n-1);

}
for (int i = 1; i < 40; i++)
{
Console.WriteLine($"{i}!={Factorial(i)}");
}