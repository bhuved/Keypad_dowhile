// See https://aka.ms/new-console-template for more information
//BasicLoops Lab-Description 5 door keypad entry using do-while loop
Console.WriteLine("***BasicLoops Lab-Description 5 door keypad using do-while loop***");
bool doorLocked = true;
int keyCode = 13579;
do
{
    Console.WriteLine("Enter a Keycode");
    int enteredKeyCode = Convert.ToInt32(Console.ReadLine());
    if (enteredKeyCode == keyCode)
    {
        doorLocked = false;
        Console.WriteLine("Correct! Welcome");
    }
    else { Console.Write("Wrong One, try again! "); }

}while(doorLocked);

//bool doorLockedA = true;
Console.WriteLine("***BasicLoops Lab-Description 5 door keypad with attempts using do-while loop***");
int keyCodeA = 13579;
int nofAttempts = 1;
do
{
        Console.WriteLine("Enter a Keycode");
        int enteredKeyCodeA = Convert.ToInt32(Console.ReadLine());
        
        if (enteredKeyCodeA == keyCodeA)
        {
            //doorLockedA = false;
            Console.WriteLine("Correct! Welcome");
            break;
        }
       
        Console.Write("Wrong One! "); 
        
        nofAttempts++;

} while (nofAttempts <= 5);

if (nofAttempts > 5)
{ Console.WriteLine("Too many incorrect Ateempts"); }

