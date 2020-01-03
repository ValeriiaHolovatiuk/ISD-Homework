using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_3._2
{
    class Program
    {
        interface IPlayble
        {
            void Play();
            void Pause();
            void Stop();
        }

        interface IRecodable
        {
            void Record();
            void Pause();
            void Stop();
        }

        class Player : IPlayble, IRecodable
        {
            public void Play()
            {
                Console.WriteLine("Start play.");
            }

            public void Record()
            {
                Console.WriteLine("Start record.");
            }

            public void Pause()
            {
                Console.WriteLine("Pause.");
            }

            public void Stop()
            {
                Console.WriteLine("Stop.");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            player.Pause();
            player.Stop();

            Console.WriteLine();

            player.Record();
            player.Pause();
            player.Stop();
        }
    }
}
