using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace slotaloha
{
    public class SingleTag
    {
        private int m_f;
        private string m_tag;
        private int m_interval;
        public SingleTag(string tag)
        {
            m_tag = tag;
        }
        public int recvf(int f)
        {
            m_f = f;
            return 0;
        }
        public string Scan(int index)
        {
            if (m_f == 0)
            {
                Console.WriteLine("f = 0?");
                return string.Empty;
            }
            m_interval = (new Random()).GetHashCode() % m_f;
            if (index % m_f == m_interval)
            {
                return m_tag;
            }
            else
            {
                return string.Empty;
            }
            //ThreadPool.QueueUserWorkItem(loop,(int)f);
        }
    }
}
