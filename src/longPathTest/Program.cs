using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longPathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Works fine
            System.IO.DirectoryInfo sysDirectory = new System.IO.DirectoryInfo("C:\\TEST");
            sysDirectory.EnumerateFiles();


            //Does not compile:
            //'Pri.LongPath.DirectoryInfo' does not contain a definition for 'EnumerateFiles' 
            //and no extension method 'EnumerateFiles' accepting a first argument of type 
            //'Pri.LongPath.DirectoryInfo' could be found (are you missing a using directive or an assembly reference?)
            Pri.LongPath.DirectoryInfo longDirectory = new Pri.LongPath.DirectoryInfo("C:\\TEST");
            longDirectory.EnumerateFiles();

        }
    }
}
