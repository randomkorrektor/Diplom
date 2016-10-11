using DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class MessageManager
    {
        public static Message[] GetMessageBox(int userId)
        {
            return Context.Instance.messages.Where(m => m.idTo == userId).ToArray();
        }

        public static void CreateMessage(string text, int idTo,int idFrom)
        {
            Context.Instance.messages.Add(new Message()
            {
                text = text,
                idTo = idTo,
                idFrom = idFrom,
                date = DateTime.Now.Ticks
            });

            //Context.Instance.SaveChanges();
        }
    }
}
