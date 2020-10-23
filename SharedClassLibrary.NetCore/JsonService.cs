using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharedClassLibrary.NetCore
{
    public static class JsonService
    {
        public static void WriteToFile(string filename, Person person)
        {
            var json = JsonConvert.SerializeObject(person);

            using StreamWriter writer = new StreamWriter(filename);
            writer.Write(json);
        }
    }
}
