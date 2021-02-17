using System;
using System.Threading.Tasks.Dataflow;

namespace orchestra
{
    public abstract class instrument
    {
        public string name { get; set; }
        public string play { get; set; }

        public string type { get; set; }

        public instrument(string _play, string _name, string _type)
        {
            name = _name;
            play = _play;
            type = _type;
        }

        public override string ToString()
        {
            return $"{name}, {play} , {type} family";

        }
    }

    public class Keyboard : instrument
    {
        public Keyboard(string _name, string _play, string _type) : base(_name, _play, _type)
        {

        }
    }
    public class Brass : instrument
    {
        public Brass(string _name, string _play, string _type) : base(_name, _play, _type)
        {

        }
    }

    public class Strings : instrument
    {
        public Strings(string _name, string _play, string _type) : base(_name, _play, _type)
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            instrument piano = new Keyboard("piano sound", "Piano", "Keyboard");
            instrument guitar = new Strings("guitar sound", "Guitar", "Strings");
            instrument drum = new Brass("drum sound", "Drum", "Brass");
            instrument cello = new Strings("cello sound", "Cello", "Strings");
            instrument Harp = new Strings("Harp sound", "Harp", "Strings");
            instrument Violin = new Strings(" Violin sound", " Violin", "Strings");


            Console.WriteLine(piano);
            Console.WriteLine(drum);
            Console.WriteLine(guitar);
            Console.WriteLine(cello);
            Console.WriteLine(Harp);
            Console.WriteLine(Violin);

        }
    }
}
