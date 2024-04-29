// See https://aka.ms/new-console-template for more information
using IntroLibrary;

Console.WriteLine("Hello, World!\n");

PersonModel p = new PersonModel
{
    FirstName = "Deyvid Rannyere",
    LastName = "Costa"
};

Console.WriteLine($"{ p.FirstName } {p.LastName} is my name");

/* for(int i = 1; i <= 10; i++)
{
    Console.WriteLine("Val -> " + i);
}

Console.WriteLine("\n This is it!"); */