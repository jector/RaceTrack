using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers;

public class Manolo: Driver
{
    public Manolo(RaceCar car) : base(car)
    {
        Name = "Manolo";
        SkillLevel = 10;
    }

    public override void Drive()
    {
        Car.Accelerate(SkillLevel);
    }

}