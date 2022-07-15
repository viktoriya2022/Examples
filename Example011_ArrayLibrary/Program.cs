void FillArray(int[] collection) //задаем массив collection

{
    int length = collection.Length; //получаем длину массива
    int index = 0; //исходная позиция индекс
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //положим в позицию индекс массива коллекшн новое случайное число от 1 до 10
        index++;
    }
}

void PrintArray(int[] col) //метод для вывода на печать массива
{
    int count = col.Length; //обозначим колво элементов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
        //при void не используем return
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создать новый массив в 10 элементов

FillArray(array); //заполняем массив
array[4]=4; //положим в ячейку 4 массива array 4
array[6]=4; //положим в ячейку 6 массива array 4
PrintArray(array); //распечатываем массив
Console.WriteLine(); //выводим пустую строку
int pos = IndexOf(array, 44); //рез-т работы метода IndexOf поместим в переменную pos
Console.WriteLine(pos);
