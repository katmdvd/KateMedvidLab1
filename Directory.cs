using System;
namespace laba_4
{
    class Directori : Disk
    {
        public Directori() : base()
        {
            capacity = 600;
            mp3 = 11;
        }

        public override void Placement()
        {

            Console.WriteLine("Директорія розташована на екрані вашого ПК");
        }

        public override void Capacity()
        {
            Console.WriteLine($"Її розмір:" + capacity + "МБ");
            Console.WriteLine($"Кількість аудіо файлів у директорії:" + mp3 + " треків");
        }

        public void Type()
        {
            Console.WriteLine("Тип об'єкту в Директорії:" + mp3.GetType());
            Console.WriteLine();
        }

    }
}

