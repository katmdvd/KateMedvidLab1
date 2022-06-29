using System;
using laba_4;


namespace HardDrive
{
    //Створити суперклас Диск і підкласи Директорія, Файл, Архів, Mp3.

    //Визначити тип об’єкту, які містяться в директорії.         

    //Вивести кількість аудіофайлів в директорії.             
    //Вивести на екран повідомлення про запуск файлу.           
    //Вивести на екран розмір директорії.                        

    class Program
    {
        static void Main(string[] args)
        {
            Directori d = new Directori();
            d.Info();
            d.Placement();
            d.Capacity();
            d.Type();

            Archive a = new Archive();
            a.Placement();
            a.Capacity();

            Filee f = new Filee();
            f.Placement();
            f.Work();
            f.Time();

            MP3 m = new MP3();
            m.Placement();
            m.Time();
            Console.ReadLine();

        }

    }

}
