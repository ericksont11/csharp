namespace SdetBootcampDay2.TestObjects.Examples.DIP_After
{
    public class Computer
    {
        private readonly Keyboard _keyboard;
        private readonly IMonitor _monitor;

        public Computer(Keyboard keyboard, IMonitor monitor)
        {
            this._keyboard = keyboard;
            this._monitor = monitor;
        }
    }

    public class Keyboard
    {
    }

    public interface IMonitor
    {
        public void ChangeResolution();
    }

    public class HDMonitor : IMonitor
    {
        public void ChangeResolution(){
            Console.WriteLine("Test");
        }
    }

    public class FourKMonitor : IMonitor
    {
        public void ChangeResolution(){
            Console.WriteLine("Test");
        }
    }
}
