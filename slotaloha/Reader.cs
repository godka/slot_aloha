using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace slotaloha
{
    public class Reader
    {
        List<SingleTag> m_tags;
        public Reader()
        {
            m_tags = new List<SingleTag>();
        }

        public void Add(SingleTag tag){
            m_tags.Add(tag);
        }
        public void Sendf(int f)
        {
            foreach (SingleTag t in m_tags)
            {
                t.recvf(f);
            }
        }
        public void StartLoop()
        {
            for (int i = 0;; i++)
            {
                int times = 0;
                //string tmp = string.Empty;
                string result = string.Empty;
                foreach (SingleTag t in m_tags)
                {
                    string tmp = t.Scan(i);
                    if (!tmp.Equals(string.Empty))
                    {
                        result = tmp;
                        times++;
                    }
                }
                string buffer = string.Empty;
                switch(times){
                    case 0:
                        buffer = "no response";
                        break;
                    case 1:
                        buffer = "get a result:" +　result;
                        break;
                    default:
                        buffer = "conllision";
                        break;
                }
                Console.WriteLine("slot:{0},{1}", i, buffer);
                Thread.Sleep(500);
            }
        }
    }
}
