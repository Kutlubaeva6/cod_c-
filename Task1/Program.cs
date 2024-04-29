// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.WriteLine("Введите номер задачи (от 1 до 4)");
//             int task_number = Convert.ToInt16(Console.ReadLine());
//             switch (task_number)
//             {
//                 case 1: task_1(); break;
//                 case 2: task_2(); break;
//                 case 3: task_3(); break;
//                 case 4: task_4(); break;
//                 default: Console.WriteLine("нет такой задачи"); break;
//             } 
//             Console.ReadKey();
//         }

//         public static void task_1() {
//             Console.WriteLine("Введите число для проверки кратно ли оно на 7 и на 23");
//             int x = Convert.ToInt32(Console.ReadLine());
//             int a = x % 7, b = x % 23;
//             if (a == 0 && b == 0 ) { Console.WriteLine("Делится"); }
//             else { Console.WriteLine("Не делится"); }
            
//         }
//         public static void task_2() {
//             Console.WriteLine("Введите координату x: ");
//             int x = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите координату y: ");
//             int y = Convert.ToInt32(Console.ReadLine());

//             if (x > 0 && y > 0) { Console.Write(1); }
//             if (x > 0 && y < 0) { Console.Write(4); }
//             if (x < 0 && y > 0) { Console.Write(2); }
//             if (x < 0 && y < 0) { Console.Write(3); }
//             Console.Write(" четверть");
//         }
//         public static void task_3() {
//             Console.WriteLine("Введите число из интервала [10,99] чтобы найти наибольшую цифру числа");
//             int x = Convert.ToInt32(Console.ReadLine());
//             int a = x / 10, b = x % 10;
//             if (a > b) { Console.WriteLine(a); }
//             else Console.WriteLine(b + " наибольшая цифра данного числа");
//         }
//         public static void task_4() {
//             Console.WriteLine("Введите натуральное число");
//             string str_1 = "";
//             foreach(char el in Console.ReadLine())
//             {str_1 += el + ",";}
//             Console.Write(str_1.Substring(0,str_1.Length -1));
//         }
        
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем массив из 10 целых чисел от 1 до 100
//         int[] array = GenerateArray();

//         // Выводим массив на экран
//         Console.WriteLine("Массив:");
//         PrintArray(array);

//         // Ищем количество элементов в отрезке [10, 90]
//         int count = CountElementsInRange(array, 10, 90);

//         // Выводим результат
//         Console.WriteLine($"Количество элементов в отрезке [10, 90]: {count}");

//         Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
//     }

//     // Метод для генерации массива из 10 целых чисел от 1 до 100
//     static int[] GenerateArray()
//     {
//         int[] array = new int[10];
//         Random random = new Random();

//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(1, 101); // Генерируем случайное число от 1 до 100
//         }

//         return array;
//     }

//     // Метод для вывода массива на экран
//     static void PrintArray(int[] array)
//     {
//         foreach (var element in array)
//         {
//             Console.Write(element + " ");
//         }
//         Console.WriteLine();
//     }

//     // Метод для подсчета количества элементов в заданном отрезке
//     static int CountElementsInRange(int[] array, int lowerBound, int upperBound)
//     {
//         int count = 0;

//         foreach (var element in array)
//         {
//             if (element >= lowerBound && element <= upperBound)
//             {
//                 count++;
//             }
//         }

//         return count;
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем массив из 10 целых чисел
//         int[] numbers = new int[] { 7, 5, 8, 13, 16, 21, 24, 30, 37, 42 };

//         // Переменная для хранения количества четных чисел
//         int evenCount = 0;

//         // Проходим по каждому элементу массива
//         foreach (int number in numbers)
//         {
//             // Проверяем, является ли текущее число четным
//             if (number % 2 == 0)
//             {
//                 // Если да, увеличиваем счетчик четных чисел
//                 evenCount++;
//             }
//         }

//         // Выводим результат
//         Console.WriteLine("Количество четных чисел в массиве: " + evenCount);

//         // Ждем нажатия клавиши перед завершением программы
//         Console.ReadKey();
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем массив вещественных чисел с ненулевой дробной частью
//         double[] numbers = { 1.23, 4.56, 7.89, 2.34, 5.67 };

//         // Находим максимальный и минимальный элементы массива
//         double maxNumber = numbers[0];
//         double minNumber = numbers[0];

//         foreach (double number in numbers)
//         {
//             if (number > maxNumber)
//                 maxNumber = number;

//             if (number < minNumber)
//                 minNumber = number;
//         }

//         // Находим разницу между максимальным и минимальным элементами
//         double difference = maxNumber - minNumber;

//         // Выводим результат
//         Console.WriteLine("Массив вещественных чисел: [" + string.Join(", ", numbers) + "]");
//         Console.WriteLine("Максимальный элемент: " + maxNumber);
//         Console.WriteLine("Минимальный элемент: " + minNumber);
//         Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
//     }
// }



// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//          static void Main()
//          {
//             Console.WriteLine("Введите номер задачи (от 1 до 3)");
//             int task_number = Convert.ToInt16(Console.ReadLine());
//             switch (task_number)
//             {
//                 case 1: task_1(); break;
//                 case 2: task_2(); break;
//                 case 3: task_3(); break;
//                 default: Console.WriteLine("нет такой задачи"); break;
//             } 
//             Console.ReadKey();
//         }

//              public static void task_1() 
//                 {
//             while (true)
//             {
//             Console.Write("Введите целое число или 'q' для завершения: ");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }

//             if (int.TryParse(input, out int number))
//             {
//                 if (IsSumOfDigitsEven(number))
//                 {
//                     Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
//                     break;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Сумма цифр числа {number} нечетная.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для завершения.");
//             }
//             }
//                  }

//     static bool IsSumOfDigitsEven(int number)
//     {
//         int sum = 0;

//         while (number != 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }

//         return sum % 2 == 0;
//             }

//             public static void task_2()
//             {
//         int arraySize = 10;
//         int[] randomNumbers = GenerateRandomNumbers(arraySize);

//         Console.WriteLine("Сгенерированный массив: ");
//         PrintArray(randomNumbers);

//         int evenCount = CountEvenNumbers(randomNumbers);
//         Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
//             }

//     static int[] GenerateRandomNumbers(int size)
//     {
//         Random random = new Random();
//         int[] numbers = new int[size];

//         for (int i = 0; i < size; i++)
//         {
//             numbers[i] = random.Next(100, 1000);
//         }

//         return numbers;
//     }

//     static void PrintArray(int[] array)
//     {
//         foreach (var number in array)
//         {
//             Console.Write(number + " ");
//         }
//         Console.WriteLine();
//     }

//     static int CountEvenNumbers(int[] array)
//     {
//         int count = 0;

//         foreach (var number in array)
//         {
//             if (number % 2 == 0)
//             {
//                 count++;
//             }
//         }

//         return count;
//    }

//         public static void task_3()
//         {
//         int[] originalArr = { 2,5,6,3,1 };
//         Console.WriteLine("Исходный массив:");
//         PrintArr(originalArr);
//         ReverseArr(originalArr);
//         Console.WriteLine("Перевернутый массив:");
//         PrintArr(originalArr);
//         }

//     static void ReverseArr(int[] arr)
//     {
//         int left = 0;
//         int right = arr.Length - 1;

//         while (left < right)
//         {
//             int temp = arr[left];
//             arr[left] = arr[right];
//             arr[right] = temp;
//             left++;
//             right--;
//         }
//     }

//     static void PrintArr(int[] arr)
//     {
//         foreach (var element in arr)
//         {
//             Console.Write(element + " ");
//         }
//         Console.WriteLine();
//     }

//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] numbers = new int[,] {
//             {1, 2, 3, 4},
//             {5, 6, 7, 8},
//             {9, 10, 11, 12}
//         };

//         int x = 4;
//         int y = 4;

//         int result = GetElementValue(numbers, x, y);

//         if (result != -1)
//         {
//             Console.WriteLine(result);
//         }
//         else
//         {
//             Console.WriteLine("Позиция по рядам выходит за пределы массива");
//         }
//     }

//     static int GetElementValue(int[,] array, int x, int y)
//     {
//         int numRows = array.GetLength(0);
//         int numColumns = array.GetLength(1);

//         if (x >= 1 && x <= numRows && y >= 1 && y <= numColumns)
//         {
//             return array[x - 1, y - 1];
//         }
//         else
//         {
//             return -1; // Возвращаем -1 для обозначения, что позиция выходит за пределы массива
//         }
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] numbers = new int[,] {
//             {1, 2, 3, 4},
//             {5, 6, 7, 8},
//             {9, 10, 11, 12}
//         };

//         Console.WriteLine("Исходный массив:");
//         PrintArray(numbers);

//         SwapFirstAndLastRow(numbers);

//         Console.WriteLine("\nМассив после обмена:");
//         PrintArray(numbers);
//     }

//     static void SwapFirstAndLastRow(int[,] array)
//     {
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         if (rows < 2)
//         {
//             // Нечего менять, массив содержит меньше двух строк
//             return;
//         }

//         // Сохраняем первую строку во временном массиве
//         int[] tempRow = new int[cols];
//         for (int j = 0; j < cols; j++)
//         {
//             tempRow[j] = array[0, j];
//         }

//         // Копируем последнюю строку в первую
//         for (int j = 0; j < cols; j++)
//         {
//             array[0, j] = array[rows - 1, j];
//         }

//         // Копируем временный массив (первую строку) в последнюю строку
//         for (int j = 0; j < cols; j++)
//         {
//             array[rows - 1, j] = tempRow[j];
//         }
//     }

//     static void PrintArray(int[,] array)
//     {
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(array[i, j] + "   ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


    // public static void PrintArray(int[,] array)
    // {
    //     int rows = array.GetLength(0);
    //     int cols = array.GetLength(1);

    //     for (int i = 0; i < rows; i++)
    //     {
    //         for (int j = 0; j < cols; j++)
    //         {
    //             Console.Write(array[i, j] + "   ");
    //         }
    //         Console.WriteLine();
    //     }
    // }

    // // Обмен первой с последней строкой
    // public static int[,] SwapFirstLastRows(int[,] array)
    // {
    //     int rows = array.GetLength(0);
    //     int cols = array.GetLength(1);

    //     if (rows >= 2)
    //     {
    //         // Сохраняем первую строку во временном массиве
    //         int[] tempRow = new int[cols];
    //         for (int j = 0; j < cols; j++)
    //         {
    //             tempRow[j] = array[0, j];
    //         }

    //         // Копируем последнюю строку в первую
    //         for (int j = 0; j < cols; j++)
    //         {
    //             array[0, j] = array[rows - 1, j];
    //         }

    //         // Копируем временный массив (первую строку) в последнюю строку
    //         for (int j = 0; j < cols; j++)
    //         {
    //             array[rows - 1, j] = tempRow[j];
    //         }
    //     }

    //     return array;
    // }

    // // Обмен элементами массива
    // public static void SwapItems(int[,] array, int i)
    // {
    //     // Здесь вы можете реализовать логику обмена элементами массива, используя индекс i
    //     // Например, для обмена элементов внутри строки:
    //     int temp = array[i, 0];
    //     array[i, 0] = array[i, 1];
    //     array[i, 1] = temp;
    // }

    // public static void PrintResult(int[,] numbers)
    // {
    //     Console.WriteLine("Исходный массив:");
    //     PrintArray(numbers);

    //     // Обмен первой и последней строк
    //     SwapFirstLastRows(numbers);

    //     Console.WriteLine("\nМассив после обмена:");
    //     PrintArray(numbers);

    //     // Пример обмена элементами массива
    //     // Здесь используется SwapItems для обмена элементами внутри строки с индексом 1
    //     SwapItems(numbers, 1);

    //     Console.WriteLine("\nМассив после дополнительного обмена элементами:");
    //     PrintArray(numbers);
    // }

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] numbers = new int[,] {
//             {1, 2, 3},
//             {1, 1, 0},
//             {7, 8, 2},
//             {9, 10, 11}
//         };

//         int minSumRow = FindRowWithMinSum(numbers);

//         Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");
//     }

//     static int FindRowWithMinSum(int[,] array)
//     {
//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         int minSum = int.MaxValue;
//         int minSumRow = -1;

//         for (int i = 0; i < rows; i++)
//         {
//             int currentSum = 0;

//             for (int j = 0; j < columns; j++)
//             {
//                 currentSum += array[i, j];
//             }

//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minSumRow = i;
//             }
//         }

//         return minSumRow;
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         char[,] charArray = {
//             { 'H', 'e', 'l', 'l', 'o' },
//             { 'W', 'o', 'r', 'l', 'd' }
//         };

//         string resultString = CharArrayToString(charArray);
//         Console.WriteLine(resultString);
//     }

//     static string CharArrayToString(char[,] charArray)
//     {
//         int rows = charArray.GetLength(0);
//         int cols = charArray.GetLength(1);

//         char[] charArray1D = new char[rows * cols];

//         int index = 0;
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 charArray1D[index] = charArray[i, j];
//                 index++;
//             }
//         }

//         return new string(charArray1D);
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         char[,] twoDimArray = { {'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd'} };

//         string resultString = ConvertToLowerCase(twoDimArray);

//         Console.WriteLine("Исходная строка: ");
//         PrintArrayRow(twoDimArray, 0);

//         Console.WriteLine("Результат: ");
//         Console.WriteLine(resultString);
//     }

//     static string ConvertToLowerCase(char[,] array)
//     {
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);
//         string result = "";

//         for (int col = 0; col < cols; col++)
//         {
//             char currentChar = array[0, col];

//             if (char.IsUpper(currentChar))
//             {
//                 result += char.ToLower(currentChar);
//             }
//             else
//             {
//                 result += currentChar;
//             }
//         }

//         return result;
//     }

//     static void PrintArrayRow(char[,] array, int row)
//     {
//         int cols = array.GetLength(1);

//         for (int col = 0; col < cols; col++)
//         {
//             Console.Write(array[row, col]);
//         }
//         Console.WriteLine();
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите строку из слов, разделенных пробелами:");
//         string inputString = Console.ReadLine();

//         string reversedString = ReverseWords(inputString);

//         Console.WriteLine("Результат:");
//         Console.WriteLine(reversedString);
//         Console.ReadLine();
//     }

//     static string ReverseWords(string input)
//     {
//         string[] words = input.Split(' ');
//         Array.Reverse(words); // Обратный порядок слов в массиве
//         string reversedString = string.Join(" ", words); // Объединение слов в строку с пробелами
//         return reversedString;
//     }
// }


