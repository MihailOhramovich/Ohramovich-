// static int[] Numbers(int [] a)
// {   
//     for(int i =0;i<a.Length;i++)
//     {
//         a[i]=a[i]*-1;
//     }
//     return a;
// }

// static bool SearchNumber(int[]a, int b)
// {  
//     for(int i =0; i<a.Length;i++)
//     {
//         if(a[i]==b)
//         {
//             return true;
//         }
//     }  
//     return false;   
// }

// int SearchCount(int[]a, int b , int c)
// {
//     int count=0;
//     for(int i=0; i<a.Length; i++)
//     {
//         if(a[i]>b&&a[i]<c)
//         count++;

//     }
// return count;
// }

int ReadInt (string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }

int[] CreateArray(int size, int minValue, int maxValue)
    {
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        array[i] =new Random().Next(minValue, maxValue+1);
        return array;
    }  
    
int AnEvenNumber(int[] array)
    {
        int count=0;
        for(int i=0; i<array.Length; i++)
        {
            if(array[i]%2==0)
            count++;
        }
        return count;

    }    


    void ShowArray(int[]array)
    {
        for( int i = 0;i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
    }
    void ShowDoubleArray(double[]array)
    {
        for( int i = 0;i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
    }

int SumOddNumbers(int[] array)
{
    int count =0;
    for(int i=0; i<array.Length;i++)
    {
        if(i%2!=0)
        count+=array[i];
    }
    return count;
}

double[] CreateArrayDouble(int size, int min, int max) 
{ 
    double[] array = new double[size]; 
    for (int i=0; i<size; i++) 
    { 
        array[i] = new Random().NextDouble()+ new Random().Next(min+max); 
        array[i]=Math.Round(array[i],2); 
    } 
    return array;
}

double MinMaxDoubleArray(Double[] array)
        
        {
            double min=array[0];
            double max=0;
            double count;
            
            for(int i=0; i<array.Length; i++)
                {
                    if(array[i]>max)
                    {
                    max=array[i];
                    }else if(array[i]<min)
                    {
                        min=array[i];
                    }
                }
                count =max-min;
                return count;

        }


int size = ReadInt("Введите количество элементов в массиве");
int minValue = ReadInt("Введите минимально число");
int maxValue = ReadInt("Введите максимальное число");
    // int[]myArray = CreateArray(size, minValue, maxValue);
    double [] myArray =CreateArrayDouble(size, minValue, maxValue);
    ShowDoubleArray(myArray);

    // ShowArray(myArray);


//  1---   Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//  2---   Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//  3---   Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine($"Even numbers - {AnEvenNumber(myArray)}");
// Console.WriteLine($"Sum Odd Numbers - {SumOddNumbers(myArray)}");
Console.WriteLine($"The difference between the numbers - {MinMaxDoubleArray(myArray)}");




