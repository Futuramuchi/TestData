using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ServiceCenterApp.AppData
{
    public class PermanentData
    {
        public static ServiceCenterEntities Ent;
        public static Frame Frame;
        public static Service Service { get; set; }
        public static Client Client { get; set; }
        public static ClientService ClientService { get; set; }
    }
}
