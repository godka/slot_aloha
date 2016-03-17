using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slotaloha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "1000", "1001", "1010"};
            var reader = new Reader();           
            foreach (string ss in s)
            {
                var singletag = new SingleTag(ss);
                reader.Add(singletag);
            }
            reader.Sendf(4);
            reader.StartLoop();
        }
    }
}
