using System;

class ReflectingActivity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity()
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }
    public void Run()
    { }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}