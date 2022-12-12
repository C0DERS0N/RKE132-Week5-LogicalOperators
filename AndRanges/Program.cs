// And

// Temp <= 0 - A bit cold
// Temp > 0 And Temp >= 10 - Fine
// Temp >= 10 And Temp <= 15 - Comfy (Usual room temperature)
// Temp >= 15 And Temp < 20 - A bit too warm
// Temp >= 20 And Temp <= 30 - Hot (Typical summer)
// Temp >= 30 - Like a hotspring (41°C, melts your brain juice...)

Console.WriteLine("What's your current room temperature?");
int Temp = Int32.Parse(Console.ReadLine());

if (Temp >= 30)
{
    Console.WriteLine("It melts your brain juice!");
}
else if (Temp < 30 && Temp >= 20)
{
    Console.WriteLine("It's hot!");
}
else if (Temp < 20 && Temp >= 15)
{
    Console.WriteLine("It's a bit too warm.");
}
else if (Temp < 15 && Temp >= 10)
{
    Console.WriteLine("It's nice and comfy.");
}
else if (Temp < 10 && Temp > 0)
{
    Console.WriteLine("It's fine.");
}
else
{
    Console.WriteLine("It's a bit cold.");
}
