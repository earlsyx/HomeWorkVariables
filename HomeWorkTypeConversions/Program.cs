

// capture user age, 
// how old the ywill be in 25 years
// how old they are 25 years ago
// print

Console.Write("Age:");
string? ageText = Console.ReadLine();
//int? actualAge = int.Parse(age);

bool isValidAge = int.TryParse(ageText, out int actualAge);

// casting, tryparse
Console.WriteLine($"You will be {actualAge + 25} in 25 years also your age 25 years ago was {actualAge - 25}");
