using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een nummer");
            int geluid = Convert.ToInt32(Console.ReadLine());
            if (geluid == 1)
            {
                //speelt het geluid af
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/wolf.wav");
                player.Play();
                Console.WriteLine("Wolf");
                Console.ReadLine();
            }
            else if (geluid == 2)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/Turtle.wav");
                player.Play();
                Console.WriteLine("Turtle");
                Console.ReadLine();
            }
            else if (geluid == 3)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/hyena.wav");
                player.Play();
                Console.WriteLine("Hyena");
                Console.ReadLine();
            }
            else if (geluid == 4)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/jaguar.wav");
                player.Play();
                Console.WriteLine("Jaguar");
                Console.ReadLine();
            }
            else if (geluid == 5)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/hog.wav");
                player.Play();
                Console.WriteLine("Hog");
                Console.ReadLine();
            }
            else if (geluid == 6)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/baboon.wav");
                player.Play();
                Console.WriteLine("Baboon");
                Console.ReadLine();
            }
            else if (geluid == 7)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/bark.wav");
                player.Play();
                Console.WriteLine("Bark");
                Console.ReadLine();
            }
            else if (geluid == 8)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/meme.wav");
                player.Play();
                Console.WriteLine("Meme");
                Console.ReadLine();
            }

            else if (geluid == 9)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/Vrouw.wav");
                player.Play();
                Console.WriteLine("Vrouw");
                Console.ReadLine();
            }
            else if (geluid == 10)
            {
                Geluid();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("dat is geen goed nummer");
            }
            Console.ReadKey();

        }
        public static void Geluid()
        {
            //zorgt voor een random geluid
            Random rnd = new Random();
            int number = rnd.Next(1, 9);
            int geluid = number;
            if (geluid == 1)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/wolf.wav");
                player.Play();
                Console.WriteLine("Wolf");
                Console.ReadLine();
            }
            else if (geluid == 2)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/Turtle.wav");
                player.Play();
                Console.WriteLine("Turtle");
                Console.ReadLine();
            }
            else if (geluid == 3)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/hyena.wav");
                player.Play();
                Console.WriteLine("Hyena");
                Console.ReadLine();
            }
            else if (geluid == 4)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/jaguar.wav");
                player.Play();
                Console.WriteLine("Jaguar");
                Console.ReadLine();
            }
            else if (geluid == 5)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/hog.wav");
                player.Play();
                Console.WriteLine("Hog");
                Console.ReadLine();
            }
            else if (geluid == 6)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/baboon.wav");
                player.Play();
                Console.WriteLine("Baboon");
                Console.ReadLine();
            }
            else if (geluid == 7)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/bark.wav");
                player.Play();
                Console.WriteLine("Bark");
                Console.ReadLine();
            }
            else if (geluid == 8)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/meme.wav");
                player.Play();
                Console.WriteLine("Meme");
                Console.ReadLine();
            }

            else if (geluid == 9)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:/Users/mylok/OneDrive/Documents/Vrouw.wav");
                player.Play();
                Console.WriteLine("Vrouw");
                Console.ReadLine();
            }
            Console.ReadKey();

        }

    }
}
