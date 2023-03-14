using System;

namespace RaceTrack.RaceTrack.Cars;

public class AlfaRomeo : RaceCar
{

        public AlfaRomeo()
        {
            Name = "Alfa Romeo";
            TopSpeed = 110;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is the best!");
        }
        
}