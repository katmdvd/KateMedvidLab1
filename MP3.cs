using System;
namespace laba_4
{
    public class MP3
    {
        public double time { get; set; }

        public MP3()
        {
            time = 0.17;
        }
        

        public void Time()
        {
            Console.WriteLine($"Середня швидкість роботи, а саме відкриття МР3 файлу {time}" + "c");
        }

        public virtual void Placement()
        {
            Console.WriteLine("Наявні аудіофайли МР3 розташовані в папці");
        }

    }
}

