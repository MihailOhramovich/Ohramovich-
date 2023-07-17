// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*Console.WriteLine("input number ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number ");
int b =Convert.ToInt32(Console.ReadLine());
int count=1;
int a1=1;

 while(count<=b)
    {
        a1=a1*a;
        count++;
    }

Console.WriteLine(a1);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*int Sum(int a)
{
int count =0;
 while(a>0)
 {
    count+=a%10;
    a=a/10;
 }
 return count;
}

Console.WriteLine("Input Number ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of digits in a number = " +Sum(a) );
*/
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void CreateArray(int[] arrary)
    
    {
        for(int i=0; i<arrary.Length; i++)
        {
            
            arrary[i]=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите элемент массива  = " + arrary[i]);
        }
        return;
    }
    Console.WriteLine("Specify the size of the array");
    int m=Convert.ToInt32(Console.ReadLine());
    int[] array = new int [m];
    CreateArray(array);
        Console.Write("[");
        for( int i =0;i<array.Length-1;i++)
        {
            
            Console.Write($"{array[i]}, " );
             
        }
         Console.Write($"{array[array.Length-1]}");
        Console.Write("]");
    
