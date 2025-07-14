

// ask user : name , age.
// if Bob or Sue, call them prof
// if under 21, recommend waiting X years to start class.

Console.Write("What is your name:");
string? name = Console.ReadLine();




Console.Write("What is your age:");
string? ageText = Console.ReadLine();

string formattedName;

if(int.TryParse(ageText, out int age) == false)
{
    Console.WriteLine("Not a valid age");
    return; //current method static void main
    // exit out of the current method, when we return end the program.
}

if (name.ToLower() == "bob" || name.ToLower() == "sue")
{
    Console.WriteLine($"Hello Professor {name}");
}
else
{
    Console.WriteLine($"Hello {name}");
}


if (age < 21)
{
    Console.WriteLine($"You should wait {21 - age} years to start this class");
}

else
{
    Console.WriteLine("Welcome to class");
}







