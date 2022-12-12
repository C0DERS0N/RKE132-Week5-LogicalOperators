// Or - ||
// Math >= 90, Biology >= 90, Chemistry >= 90;

int Math, Biology, Chemistry;

Console.WriteLine("Enter your Math result (0-100):");
Math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result (0-100):");
Biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result (0-100):");
Chemistry = Int32.Parse(Console.ReadLine());

if (Math >= 90 || Biology >= 90 || Chemistry >= 90)
{
    Console.WriteLine("Congratulations! You are accepted.");
}
else
{
    Console.WriteLine("Get lost!");
}
