using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] soundUrls = new string[] {
                "http://www.wavsource.com/snds_2016-01-10_6357263721580594/movies/2001/disconnect_me.wav",
                "http://www.wavsource.com/snds_2016-01-10_6357263721580594/movies/star_trek/2needs_of_the_many.wav",
                "http://www.wavsource.com/snds_2016-01-10_6357263721580594/movies/terminator/t2_hasta_la_vista.wav"
            };

            Random rand = new Random();
            var sound = soundUrls[rand.Next(0, soundUrls.Length)];
            var playSound = new SoundPlayer(sound);


            try
            {
                playSound.PlaySync();
                Console.WriteLine();
                Console.ReadLine();
            }
            catch (WebException)
            {
                Console.WriteLine("Sorry, no available internet connection at this time");
                throw;
            }
            
        }
    }
}
