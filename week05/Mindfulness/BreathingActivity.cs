using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            duration -= 5;

            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            duration -= 5;
        }
        DisplayEndingMessage();
    }

    private int GetDuration()
    {
        // Assuming duration is set in DisplayStartingMessage
        return _duration;
    }
}