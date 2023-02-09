/* 
* Examples of several types of Loops in c#
*/


/* For Loop */
/*
* The for loop is used to execute the code within it an set number of times
* A for loop must contain 3 componenets within the braces ( )
* Initialisation: 'int i = 0;' creates the index variable 'i'
* Termination: "i < 10;" sets the condition of when the loop will terminate - when i reaches 10 in this example
* Increment: "i++" increases the i variable by 1 each time the loop cycles
*/
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


/* Foreach */
/* 
 * For each loops are used to iterate through elemets within lists and arrays.
 */
 int[] pupilMarks = {88,56,78,56,78,34}
 foreach (int mark in pupilMarks)
 {
    Console.WriteLine("mark:" + mark);
 }


/* While Loop */
/* 
 * The while loop will execute the code block to the number of iterations set int the condition
 * In this example index is set to 0 - the while loop checks if its less than or equal to 10
 * index++ increase the index variable by 1 each time the loop executes
 */
int index = 0
while(index >= 10)
{
    Console.WriteLine("number of iterations = " + index);
    index++
}


/* Do...While */
/* 
 * Do...While loops function exactly the same way as a while loop with one exception
 * The code block will always execute at least once, even if the while condition is false
 */
int index = 0
do{
    Console.WriteLine("number of iterations = " + index);
    index++
}while(index >= 10);