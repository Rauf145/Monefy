using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy_hw_
{
    sealed class Settings
    {
        private static Settings obj;
        public static Settings GetObj()
        {
            if (obj == null)
            {
                obj = new Settings();
            }
            return obj;
        }
    }
}
