using System;

namespace Task3
{
    class Program
    {
        interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        }

        interface IRecordable
        {
            void Record();
            void Pause();
            void Stop();
        }

        class Player : IPlayable, IRecordable
        {
            public void Play()
            {
                Console.WriteLine("Воспроизведение мелодии");
            }

            public void Record()
            {
                Console.WriteLine("Запись воспроизводимой мелодии");
            }
            public void Pause()
            {
                Console.WriteLine("Пауза в случаи помех");
            }
            public void Stop()
            {
                Console.WriteLine("Остановка воспротзведения мелодия и записи");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            player.Record();
            player.Pause();
            player.Stop();
        }
    }
}
