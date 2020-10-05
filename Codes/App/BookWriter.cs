using System;

public class BookWriter : Writer
{
    public BookWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I vlog using my iPhone.");
    }

    public override void Write()
    {
        Console.WriteLine("I write books.");
    }
}