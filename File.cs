using System;
namespace laba_4
{
    public class Filee : MP3
    {
        public double time { get; set; }

        public Filee() : base()
        {
            time = 0.34;
        }

        public virtual void Placement()
        {
            Console.WriteLine("Вибрані файли знаходяться у папці");
        }

        public void Time()
        {
            Console.WriteLine($"Середня швидкість роботи звичайного файлу на диску {time}" + "c");
            Console.WriteLine();
        }

        public void Work()
        {
            Console.WriteLine("Файл запущенно (запущено) для перегляду інформації"); ;
        }

    }
}

