using SharedClassLibrary.NetCore;
using System;

namespace ReadWriteJson
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonService.WriteToFile($@"C:\Users\Berrkha\Documents\MyFiles", new Person("Mathias", "Bergquist", 46, "Degerfors"));
        }
    }
}
