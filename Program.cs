//***********************************
// Student Name : Mohammad Ali Amirkhani
// Lesson Name : Advanced Programming (1)
// Practice Number : 6
//***********************************
while (true)
{
    Console.Write("Please enter the trigonometric sequence: ");
    string Input = Console.ReadLine();
    int Number;
    if (IsInt(Input))
    {
        Number = Convert.ToInt32(Input);
    }
    else
    {
        Console.WriteLine("Please enter a correct number!!!!!");
        continue;
    }
    int Result = (Number * (Number + 1)) / 2;
    Console.WriteLine(Result);
    Console.Write("Do you want to continue?if yes enter (y): ");
    if(Console.ReadLine() == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}

static bool IsInt(string input)
{
    foreach (char c in input)
    {
        if (!Char.IsDigit(c))
        {
            return false;
        }
    }
    return true;
}