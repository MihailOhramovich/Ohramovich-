// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// int[] inputNumber(int size)
// {   
    
//     int [] array = new int[size];
//     for(int i= 0; i<array.Length; i++)
//     {
//         Console.WriteLine("input number");
//         array[i]=Convert.ToInt32(Console.ReadLine());
//     }
// return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i =0; i<array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
// }

// int Counter(int[] array)
// {
//     int count=0;
//     for(int i=0; i<array.Length; i++ )
//     {
//         if(array[i]>0)
//         count++;
//     }
//     return count;
// }   
// Console.WriteLine("Input size array");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array= inputNumber(size);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine(Counter(array)+" Чисел больше 0");


// y = 5 * x + 2
// y = 9 * x + 4;

double[] Coordinate(string message)
{
    double[] a = new double[2];
    a[0]=Convert.ToInt32(Console.ReadLine());
    a[1]=Convert.ToInt32(Console.ReadLine());
    return a;
}

bool search(double []array, double[] array2)
{
    double x;
    double y;
        if (array[1] == array2[1])
        {
            if (array[0] == array2[0]) Console.WriteLine("there is no spoon, all lines are one");
            else Console.WriteLine("The lines have nothing in common");
            return false;
        }
        else
        {
             x = (array2[0] - array[0]) / (array[1] - array2[1]);
             y = array[1]  * x + array[0] ;
        }
    Console.WriteLine($"Red lines were crossed here: ({x}, {y})");
    return true;
}

double[] a = Coordinate("Введите значение A");
double[] b = Coordinate("Введите значение B");
Console.WriteLine(search(a,b));