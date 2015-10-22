using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    internal class CopyBinaryFile
    {
        private static void Main(string[] args)
        {
            using (var source = new FileStream("../../image.jpg", FileMode.Open))
            {
                using (var copy = new FileStream("../../copyOfImage.jpg", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        copy.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
