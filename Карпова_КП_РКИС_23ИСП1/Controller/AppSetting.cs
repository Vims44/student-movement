using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карпова_КП_РКИС_23ИСП1.Controller
{
    class AppSetting
    {
        public static string ConnStr
        {
            get
            {
                return "Data Source=studentMovement.db; Version=3";
            }
        }
    }
}
