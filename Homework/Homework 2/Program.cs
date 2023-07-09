//example 15
/*
while (true)
{
Console.WriteLine("Enter the First number!");
int firstNumber=Convert.ToInt32(Console.ReadLine());
    if(firstNumber>7)
    {
    Console.WriteLine("Incorrect data entry, enter a number from 1 to 7");
    } 
    else if(firstNumber<6)
    { 
    
        Console.WriteLine("Working day");
        break;
    }
    else
    
    {
        Console.WriteLine("Weekand");
        break;
    }
}
*/

//example 10
/*
while(true)
    {
        Console.WriteLine("enter a three-digit number");
        int number=Convert.ToInt32(Console.ReadLine());
        if(number<100)
        {
            Console.WriteLine("The number is not three-digit, enter a three-digit number");
            number=Convert.ToInt32(Console.ReadLine());
        }
        else if(number>1000)
        {
            Console.WriteLine("The number is not three-digit, enter a three-digit number");
            number=Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            number=number/10%10;
            Console.WriteLine(number);
            break;
        }

    }
    */
//example 13

//int thirdnumber(int a)_
  
        
        Console.WriteLine("Enter number");
        int number =Convert.ToInt32(Console.ReadLine());

    if(number<100)
        {
        Console.WriteLine("There is no third digit");
        }
        else
        {
           while(number>1000)
           {
            number=number/10;
           }
            number=number%10;
            Console.WriteLine(number);
            
        }
        
    

    

    
