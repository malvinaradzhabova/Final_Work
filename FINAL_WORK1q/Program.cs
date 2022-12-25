//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// ["888","-4","6455","start","-145236","why", "work"]


class Program
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("Введен первоначальный массив: ");
        string[] array1 = new string[7]{"888","-4","6455","start","-145236","why", "work"};
        string[] array2 = new string[array1.Length];
        Console.WriteLine(String.Join(", ", array1));
       
        
        void GetArray(string[]array1,string[]array2)
        {
            int count=0;
            for ( int i = 0; i<array1.Length;i++)
            {
                if (array1[i].Length<=3)
                {
                    array2[count]=array1[i];
                    count++;
                }
            }

        }
        Console.WriteLine("Новый массив:  ");
        GetArray(array1,array2);
       

        void PrintArray(string[] array)
        {
            for( int i=0; i<array.Length;i++)
            {
                Console.Write($"{array[i]}");
            }
        }
        PrintArray(array2);
    }
}   