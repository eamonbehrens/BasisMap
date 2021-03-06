﻿using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class BasicUser
    {
        public int Oid { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAdministrator { get; set; }
        public bool? ChangePasswordOnFirstLogon { get; set; }
        public string Password { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
