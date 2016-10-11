using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Message
    {
        public int ID { get; set; }
        public string text { get; set; }
        public int idTo { get; set; }
        public int idFrom { get; set; }
        public long date { get; set; }

        public Message()
        {
            text = "";
            idTo = 0;
            idFrom = 0;
            date = 0;
        }
    }
}
