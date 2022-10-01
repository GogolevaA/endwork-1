//Создать массив из имеющих строк не првышаюих кол-во 3 символов.
// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,100);
    
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.WriteLine($"{array[i]}]");
//     }
// }
// try
// {
//     // Console.Write("Введите длину массива: \t");
//     int number = 8;
//     PrintArray((FillArray(number)));
// }
// catch 
// {
//     Console.WriteLine("Fatal Error!!");
// }


   Console.Write("Введите количество строк, которые хотите ввести: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
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
            Console.Write("Нажмите [Enter] для выхода...");
            Console.ReadLine();