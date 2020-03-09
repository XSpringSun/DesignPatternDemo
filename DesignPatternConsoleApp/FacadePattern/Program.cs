using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Screen screen = new Screen();
            //DVD dvd = new DVD();
            //SoundEngineer sound = new SoundEngineer();
            //Light light = new Light();

            //screen.Down();
            //dvd.PlayDVD();
            //sound.TurnOn();
            //light.TurnOff();

            Screen screen = new Screen();
            DVD dvd = new DVD();
            SoundEngineer sound = new SoundEngineer();
            Light light = new Light();
            HomeThreaterFacade homeThreaterFacade = new HomeThreaterFacade(screen,dvd,sound,light);
            homeThreaterFacade.WatchMovie();

            Console.ReadKey();
        }
    }
}
