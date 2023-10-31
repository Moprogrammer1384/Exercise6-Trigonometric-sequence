//***********************************
// Student Name : Mohammad Ali Amirkhani
// Lesson Name : Advanced Programming (1)
// Practice Number : 6
//***********************************
while (true)
{
    int StartNumber = 0;
    int EndNumber = 0;

    while (true)
    {
        Console.Write("Please enter the start number of trigonometric sequence: ");
        string Input = Console.ReadLine();
        if (IsInt(Input))
        {
            StartNumber = Convert.ToInt32(Input);
            break;
        }
        else
        {
            Console.WriteLine("Please enter a correct number !!!");
            continue;
        }
    }

    while (true)
    {
        Console.Write("Please enter the end number of trigonometric sequence: ");
        string Input = Console.ReadLine();
        if (IsInt(Input))
        {
            EndNumber = Convert.ToInt32(Input);
            break;
        }
        else
        {
            Console.WriteLine("Please enter a correct number !!!");
            continue;
        }
    }

    for (int i = StartNumber; i <= EndNumber; i++)
    {
        Console.Write($"{(i * (i + 1)) / 2}  ");
    }

    Console.WriteLine();
    Console.Write("Do you want to continue?if yes enter (y): ");
    if (Console.ReadLine() == "y")
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