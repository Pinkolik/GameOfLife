using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameOfLife
{
    public static class Serializer
    {
        public static void Serialize(object obj, string filename)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fileStream, obj);
            }
        }

        public static object Deserialize(string filename)
        {
            var formatter = new BinaryFormatter();
            object obj = null;
            using (var fileStream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                if (fileStream.Length != 0)
                    obj = formatter.Deserialize(fileStream);
            }
            return obj;
        }
    }
}
