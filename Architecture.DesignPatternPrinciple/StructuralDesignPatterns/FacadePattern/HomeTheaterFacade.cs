using System;

namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.FacadePattern
{
    public class HomeTheaterFacade
    {
        private Amplifier amp;
        private DVDPlayer dvd;
        private Projector projector;
        public HomeTheaterFacade(Amplifier amp, DVDPlayer dvd, Projector projector)
        {
            this.amp = amp;
            this.dvd = dvd;
            this.projector = projector;
        }
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            projector.On();
            amp.On();
            amp.SetVolume(5);
            dvd.On();
            dvd.Play(movie);
        }
        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            dvd.Off();
            amp.Off();
            projector.Off();
        }
    }
}
