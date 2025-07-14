

// ask user : name , age.
// if Bob or Sue, call them prof
// if under 21, recommend waiting X years to start class.

Console.Write("What is your name:");
string? name = Console.ReadLine();


if (name.ToLower() == "bob" || name.ToLower() == "sue")
{
    Console.WriteLine($"Hello Professor {name}");
}
else
{
    Console.WriteLine($"Hello {name}");
}


Console.Write("What is your age:");
string? age = Console.ReadLine();

bool validAge = int.TryParse(age, out int ageConverted);

if (validAge && ageConverted < 21)
{
    Console.WriteLine($"You should wait {21 - ageConverted} years to start this class");
}


