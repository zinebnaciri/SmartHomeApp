using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomezyDomotique
{
    class userLogName
    {
        static string UserName;
        static string type;
        public static string userName
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public static string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
