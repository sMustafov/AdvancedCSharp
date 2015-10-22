using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SlicingFile
{
    internal class SlicingFile
    {
        private static void Main(string[] args)
        {
            List<string> files = new List<string>();

            string inputFile = @"../../Malcolm.avi";
            string folderPath = @"../../";
            int parts = 4;

            Slice(inputFile, folderPath, parts);

            Assemble(files, folderPath);

        }

        public static void Slice(string source, string folder, int parts)
        {
            using (var sourceFile = new FileStream(source, FileMode.Open))
            {
                parts = int.Parse(Console.ReadLine());
                int length = (int)sourceFile.Length / parts;
                int start = 0;
                int end = length;

                for (int i = 0; i < parts; i++)
                {
                    string name = folder + "Malcolm" + i + ".avi";
                    using (FileStream destinationDirectory = new FileStream(name, FileMode.Create))
                    {
                        byte[] half = new byte[length];
                        int readBytes = sourceFile.Read(half, 0, half.Length);
                        destinationDirectory.Write(half, 0, readBytes);
                        start += length;
                    }
                }
            }
        }

        public static void Assemble(List<string> files, string destinationDirectory)
        {
            string file = destinationDirectory + "Malcolm.avi";
            var source = new FileStream(file, FileMode.Create);
            source.Close();

            using (source = new FileStream(file, FileMode.Append))
            {
                foreach (var part in files)
                {
                    using (var partSource = new FileStream(part, FileMode.Open))
                    {
                        Byte[] bytePart = new byte[partSource.Length];
                        int readBytes = partSource.Read(bytePart, 0, bytePart.Length);
                        source.Write(bytePart, 0, readBytes);
                    }
                }
            }
        }
    }
}
