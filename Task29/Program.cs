// Задача 29: Напишите программу, которая задаёт массив из 8 
//целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

    void FillArray(int[] collect)
            {
                Console.WriteLine("Введите числа: ");
                int Length = collect.Length;
                int index = 0;
                while (index < Length)
                {
                    collect[index] = int.Parse(Console.ReadLine()!);
                    index++;
                    
                     }
                     
            }

            void PrintArray(int[] col)
            {
                Console.WriteLine("Массив");
                int count = col.Length;
                int position = 0;
                while (position < count)
                {
                    Console.Write(col[position] + "; ");
                    position++;
                }
                }
            Console.WriteLine("Введите количество элементов: ");
           
            int number = int.Parse(Console.ReadLine()!);

            int[] array = new int[number];
            FillArray(array);
            
            PrintArray(array);