
//task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
bool Polindrom(int b)
{
int one = b / 10000;
int two = b % 10;
int three = b / 1000 % 10;
int four = b % 100 / 10;
if (one == two)
{
    if(three==four)
    return true;
}
return false;
}


int a =Convert.ToInt32 (Console.ReadLine());

 if(Polindrom(a))
 {
        Console.WriteLine("Polindrom"); 

 }else
 Console.WriteLine("no");
 */

 //Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
Console.WriteLine("Input coordinates A");
Console.WriteLine("x= ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y= ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z= ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("coordinates of the first point = "+(x1, y1, z1));

Console.WriteLine("Input coordinates B");
Console.WriteLine("x= ");
double x2= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y= ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z= ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("coordinates of the second point = "+(x1, y1, z1));

Double d =Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+Math.Pow((z2-z1),2));
Console.WriteLine("Distance between points =" +d);
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//4
//1 - 1
//2 - 8
//3 - 27
//4 - 64

Console.WriteLine("Input number >");
double num =Convert.ToDouble(Console.ReadLine());
int count=1;

    while(count<4)
    {
        Console.WriteLine(Math.Pow(num,count));
        count=count+1;
      
    }
