using System;

public abstract class Vessel
{
    public abstract void PrepareToMovement();
    public abstract void Move();

    public void PlayCounterStriceInACabine()
    {
        Console.WriteLine("Crew is playing");
    }
}