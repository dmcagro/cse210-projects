using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you overcame a challenge."
    };

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Reflection Activity Running...");

        DisplayEndingMessage();
    }
}