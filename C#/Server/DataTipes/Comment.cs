using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Comment
    {
        public long ID { get; set; }
        public string text { get; set; }
        public int idCreator { get; set; }
        public int idPost { get; set; }
        public DateTime date { get; set; }

        public Comment()
        {
            text = "";
            idCreator = 0;
            idPost = 0;
            date = DateTime.Now;
        }
    }
}
