

// prompt user name
// welcome tim as prof or anyone else as a student.
// make ssure TIM also is a proffessor.

Console.Write("What is your name:");
string? name = Console.ReadLine();

//if statemetes
if (name.ToLower() == "tim")
{
    Console.WriteLine("Hello Professor");
}
else if (name == "")
{
    Console.WriteLine("Not a name");
}
else
{
    Console.WriteLine("Hello Student");
}

//switch statement

switch (name.ToLower())
{
    case "tim":
        Console.WriteLine("Hello Professor");
        break;
    case "":
        Console.WriteLine("Not a student");
        break;
    default:
        Console.WriteLine("Student");
        break;
}