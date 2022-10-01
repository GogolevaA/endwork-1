// //Создать массив из имеющих строк не првышаюих кол-во 3 символов.

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
//     Console.ReadLine();
//     return strs;
// }



// void FindInArray(string[] strs)
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
//     FindInArray(FillArray(n));
    

// }
// catch
// {
//     Console.WriteLine("Fatal Error!!");
// }






 //Второй вариант решения

// string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine());
 string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        strs[i] = Console.ReadLine(); //Заполняем его
    }
    Console.WriteLine("Вы ввели следующие строки:");
    for (int i = 0; i < n; i++)
    {
        // Console.WriteLine("[ strs[i]) ]");
        Console.WriteLine($"[{strs[i]}]");
    }
// string[] array2 = new string[strs.Length];


// void SecondArrayWithIF(string[] strs)
// {
    string[] array2 = new string[strs.Length];
    int count = 0;
    for (int i = 0; i < strs.Length; i++)
    {
    if(strs[i].Length <= 3)
        {
        array2[count] = strs[i];
        // count++;
        }
    }
// }
// void PrintArray(string[] array)
// {
    // for (int i = 0; i < array2.Length; i++)
    // {
        Console.Write($"{array2[count]} ");
    // }
    Console.WriteLine();
    count++;
// }
// SecondArrayWithIF(strs);
// PrintArray(array2);