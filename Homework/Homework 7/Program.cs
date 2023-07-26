// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandomDouble (int size, int size2)
{
    double[,] myArray=new double[size,size2];

    for(int i =0; i< size; i++)
    {
        for(int j=0; j<size2; j++ )
        {
            myArray[i,j]= new Random().Next(-5,5);
            myArray[i,j]=Math.Round(myArray[i,j], 2);
        }
    }
    return myArray;
}
void PrintDoubArray(double[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
           Console.Write($"{matr[i,j]}  ");

        }
        Console.WriteLine();
    } 
}
void PrintIntArray(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j =0; j<matr.GetLength(1); j++)
        {
           Console.Write($"{matr[i,j]}  ");

        }
        Console.WriteLine();
    } 
}
int [,] CreatRandomInt(int size, int size2)
{
    int[,] myArray = new int[size,size2];
    for(int i=0; i<size; i++)
    {
        for(int j=0; j<size2;j++)
        {
            myArray[i,j]=new Random().Next(-10,10);
        }

    }
    return myArray;
}
void Search(int[,]arr, int Num, int num2)
{
    if(Num>arr.GetLength(0)&num2>arr.GetLength(1))
    {
        Console.WriteLine("числа с такими индексами в массиве нет");
    }
        else
        {
            Console.WriteLine($"{arr[Num,num2]}");
        }
   
    
}

void ArMean (double[,] arr)
{
    double a1 =0;
    
    for(int j=0; j<arr.GetLength(1); j++)
    {
        a1=0;
        for(int i=0;i<arr.GetLength(0);i++)
        {
           a1=arr[i,j]+a1; 
        }
            Convert.ToDouble(a1);
            a1= a1/arr.GetLength(1);
            a1=Math.Round(a1,2);
            Console.Write($"{a1}  ");
    }
        // Convert.ToDouble(a1);
        // a1= a1/arr.GetLength(1);
        // Console.WriteLine($"{a1}  ");
}


Console.WriteLine("Input size Array ");
int size =Convert.ToInt32(Console.ReadLine());
int size2 =Convert.ToInt32(Console.ReadLine());
double [,] array=CreateRandomDouble(size,size2);

PrintDoubArray(array);
// ArMean(array);
// Console.WriteLine("Введите число для поиска");
// int num=Convert.ToInt32(Console.ReadLine());
// int num2=Convert.ToInt32(Console.ReadLine());
// Search(array,num,num2);
 ArMean(array);

