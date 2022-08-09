// //================Выведем на консоль таблицу умножения

// for (int i = 2; i <= 10; i++) 
// {
//     for (int j = 2; j <= 10; j++) 
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


//=========== Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками
//маленькие буквы "к" заменить большими буквами "К",
//а большие буквы "С" заменить маленькими "с".

// string s= "qwerty"
//            012345
// s[3] //r

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,";

// //метод принимает строку, указываем что и на что менять
// string Replace(string text, char oldValue, char newValue)
// {
//     //заводим новую строку
//     string result = String.Empty;
//     // получаем длину строки
//     int length = text.Length;
//     //пробегаем до конца текста
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

//========== Сортировка=================

int[] arr = { 1, 8, 2, 6, 9, 1, 1, 52, 6, 3, 4 };

//Метод вывода массива на консоль
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}
//Метод сортировки. Приходит массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        //Задаем позицию "рабочего" элемента
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        //Меняем позицию рабочего элемента с найденным минимальным
        int temporary=array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);










