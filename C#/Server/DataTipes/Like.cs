using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Like
    {
        public long ID { get; set; }
        public int idCreator { get; set; }
        public int idPost { get; set; }

        public Like()
        {
            idCreator = 0;
            idPost = 0;
        }
    }
}
