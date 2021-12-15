using System;
using System.Threading;
using System.IO;

namespace TutProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AntalISträng('o', "orvar käkar kooooorvar"));
        }
        static int AntalISträng(char tecken, string text)
        {
            int antalggr = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (tecken == text[i])
                {
                    antalggr++;
                }
            }
            return antalggr;
        }
    }
}
