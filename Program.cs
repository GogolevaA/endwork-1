//Создать массив из имеющих строк не првышаюих кол-во 3 символов.

// string[] FillArray(int n)
// {// Считываем строку, переводим в число.
//     string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("Введите строку №{0}:\r\n    ", i + 1);
//         strs[i] = Console.ReadLine(); //Заполняем его
//     }
//     Console.WriteLine("Вы ввели следующие строки:");
//     for (int i = 0; i < n; i++)
//     {
//         // Console.WriteLine("[ strs[i]) ]");
//         Console.WriteLine($"[{strs[i]}]");
//     }
//     // Console.Write("Нажмите [Enter] для выхода...");
//     // Console.ReadLine();
//     return strs;
// }



// string[] FindInArray(string[] strs)
// {
//     string[] newAr = new string[strs.Length];
//     int count = 0;
//     for (int i = 0; i < strs.Length; i++)
//         if (strs[0].Length <= 3)
//         {
//             newAr[count] = strs[i];

//         }
//         Console.Write($"{newAr[count]} ");
//             // Console.WriteLine(); 
//             count++;
//          return newAr; 
// ; 
//         // else Console.WriteLine("Такого числа в массиве нет.");
// }

// void PrintArray(string[] newAr)
// {
//     for (int i = 0; i < newAr.Length; i++)
//     {
//         Console.Write($"{newAr[i]} ");
//     }
//     Console.WriteLine();
// }
// // SecondArrayWithIF(array1, array2);
// // PrintArray(array2);

// try
// {
   
//     Console.Write("Введите количество строк, которые хотите ввести: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Вот массив отформатирован по задданию: ");
//     PrintArray(FindInArray(FillArray(n)));
    

// }
// catch
// {
//     Console.WriteLine("Fatal Error!!");
// }




string[] NewArr(string[] yourString)
{
    string[] newArr = new string[yourString.Length];
    for (int i = 0; i < yourString.Length; i++)
    {
        if (yourString[i].Length <= 3) newArr[i] = yourString[i];
    }
    return newArr.Where(x => x != null).ToArray();;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    if (array.Length != 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.WriteLine($"{array[i]}]");
        }
    }
    else Console.Write("]");
}

try
{
    Console.Write("Введите массив строк через ', ':\t");
    string[] yourArray = Console.ReadLine().Split(",").ToArray();
    Console.Write("Вот ваш массив', ':\t");
    PrintArray(yourArray);
    Console.Write("Вот новый отсортированный массив:\t");
   PrintArray(NewArr(yourArray));
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}


 