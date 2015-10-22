using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTraversal
{
    class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> fileAndSize = new Dictionary<string, string>();
            List<string> files = new List<string>();
            string[] dir = Directory.GetDirectories(@"C:\Users\pc1\Desktop\HomeworkStreamsAndFiles");

            foreach (var file in dir)
            {
                long size = GetDirectorySize(file);
                fileAndSize[Path.GetFileName(file)] = size.ToString();
            }

            dir = Directory.GetFiles(@"C:\Users\pc1\Desktop\HomeworkStreamsAndFiles");
            foreach (var file in dir)
            {
                long size = GetFileSize(file);
                fileAndSize[Path.GetFileName(file)] = size.ToString();
            }
            foreach (var f in fileAndSize)
            {
                Console.WriteLine("--{0} - {1}kb", f.Key, f.Value);
            }
        }
        private static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            return di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
        }
        private static long GetFileSize(string folderPath)
        {
            FileInfo fi = new FileInfo(folderPath);
            long size = fi.Length;
            return size;
        }
    }
}
//Not Finished
