
static void greeting(String name){
        Console.WriteLine(name);
}

//method processes data - adds two numbers
static int addTwoNumbers(int num1, int num2){
        int total = num1 + num2;
        if(total == 0){
                return 100;
        } else
        {
                return total;
        }
}

int total = addTwoNumbers(20,10);

Console.WriteLine(total);



