//Example of If statement and Switch statement

int a = 5;
int b = 10;
int c = 15;

//if statement
if (a > b)
{
    Console.WriteLine("A is greater than B");
} else if(b > c)
{
    Console.WriteLine("B is greater than C");
}
else
{
    Console.WriteLine("C is greater than A and B");
}


//switch statement
//
int day = 3;
switch (s)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    default:
        Console.WriteLine("Weekend");
        break;
}