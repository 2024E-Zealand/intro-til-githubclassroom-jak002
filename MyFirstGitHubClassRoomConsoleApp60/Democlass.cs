using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Democlass
    {

        public int Numberstuff {  get; set; }
        public string? Wordstuff { get; set; }
        public double Decimalstuff { get; set; }

        public Democlass()
        {
            Numberstuff = 0;
            Wordstuff = "Empty";
            Decimalstuff = 0;
        }

        public Democlass(int number, double deci, string word)
        {
            Numberstuff = number;
            Wordstuff = word;
            Decimalstuff = deci;
        }

        public override string ToString()
        {
            return $"{Wordstuff}: {Numberstuff} & {Decimalstuff}";
        }
    }
}
