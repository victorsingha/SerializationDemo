using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization binarySerialization = new BinarySerialization();
            binarySerialization.Serialization();
            BinaryDeSerialization binaryDeSerialization = new BinaryDeSerialization();
            binaryDeSerialization.DeSerialization();
            Console.ReadKey();
        }
    }
}
