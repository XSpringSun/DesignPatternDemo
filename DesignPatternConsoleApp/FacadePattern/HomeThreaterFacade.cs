using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class HomeThreaterFacade
    {
        Screen screen;
        DVD dvd;
        SoundEngineer sound;
        Light light;

        public HomeThreaterFacade(Screen screen, DVD dvd, SoundEngineer sound, Light light)
        {
            this.screen = screen;
            this.dvd = dvd;
            this.sound = sound;
            this.light = light;
        }

        public void WatchMovie()
        {
            Console.WriteLine("开始播放电影......");
            screen.Down();
            dvd.PlayDVD();
            sound.TurnOn();
            light.TurnOff();
        }
    }
}
