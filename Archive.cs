using System;
namespace laba_4
{
    public class Archive : Disk
    {
        public Archive() : base()
        {
            capacity = 600;
        }

        public override void Capacity()
        {
            Console.WriteLine($"Розмір архіву на диску С:" + capacity + "МБ" + "\n");
        }

        public override void Placement()
        {
            Console.WriteLine("Ваш архів розташований на \"Моєму комп'ютері\"");
        }
    }
}

