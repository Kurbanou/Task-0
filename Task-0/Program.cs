using System;

namespace Task_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class File
    {
        public string Name { get; set; }

        /*public string Type { get; set; }*/

        public int Size { get; set; }

        public string Location { get; set; }

        protected File(/*string type,*/ string name, int size, string location)
        {
            Name = name;
            /*Type = type;*/
            Size = size;
            Location = location;
        }        
    }
    public abstract class PlayTime : File 
    {
        /*public string Length { get; set; }*/
        protected readonly string Length;

        protected PlayTime(/*string type,*/ string name, int size, string location, string length) :
            base(/*type,*/ name, size, location)
        {
            Length = length;
        }
    }

    public abstract class AudioParameters : PlayTime 
    { 
        public int BitRate { get; set; }

        public int SampleRate { get; set; }

        protected AudioParameters(/*string type,*/ string name, int size, string location,
            string length, int bitRate, int sampleRate) :
            base(/*type,*/ name, size, location, length)
        {
            BitRate = bitRate;
            SampleRate = sampleRate;
        }
    }

    public class Music : AudioParameters 
    { 
        public string Artist { get; set; }

        public string Album { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        protected readonly string Type="mp3";


        public Music(/*string type,*/ string name, int size, string location, // File
            int bitRate, int sampleRate, // AudioParameters
            string length, // PlayTime
            string artist, string album, string title, string year) : // Music
            base(/*type,*/ name, size, location, length, bitRate, sampleRate)
        {
            Artist = artist;
            Album = album;
            Title = title;
            Year = year;
        }

       
    }
}
