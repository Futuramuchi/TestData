﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenterApp.AppData
{
    public partial class Client
    {
        public string GetFullName
        {
            get
            {
                string FullName = $"{FirstName} {LastName} {Patronymic}";
                return FullName;
            }
        }
    }
}
