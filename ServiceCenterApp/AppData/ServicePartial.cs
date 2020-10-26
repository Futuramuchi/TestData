using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenterApp.AppData
{
    public partial class Service
    {
        public int GetTime
        {
            get
            {
                return DurationInSeconds / 60;
            }
            set
            {
                value = 0;
            }
        }
    }
}
