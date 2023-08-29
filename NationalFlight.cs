using System;
using System.Collections.Generic;

class NationalFlight : Flight
{
    List<string> surnames = new List<string>() { "Surname1", "Surname2", "Surname3" };
    public NationalFlight()
    {
    }
    public NationalFlight(int fn, int rn, string dt, string at, string dp, string ap, string ip)
    {
        flightNumber = fn;
        raceNumber = rn;
        depatureTime = dt;
        arrivalTime = at;
        depaturePlace = dp;
        arrivalPlace = ap;
        intermediatePoint = ip;
    }
    public override void Check()
    {
        Client client = new Client();
        Console.WriteLine("Enter your surname");
        client.SurName = Console.ReadLine();
        for(int i=0; i<surnames.Count;i++)
        {
            if(surnames[i] == client.SurName)
            {
                Console.WriteLine("You are eligable");
            }
            else
            {
                Console.WriteLine("You are not eligable");
            }
        }
    }
}

