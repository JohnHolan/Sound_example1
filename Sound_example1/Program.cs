using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Sound_example1
{
    class Program
    {

        static void Main(string[] args)
        {
            SoundPlayer a = new SoundPlayer(@"C:\\Users\\jhola\\Downloads\\Imagine Dragons - Believer ( cover by J.Fla ).wav");
            a.Play();
            Console.ReadKey();
        }
    }
}
