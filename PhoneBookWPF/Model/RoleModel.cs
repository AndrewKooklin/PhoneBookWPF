﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWPF.Model
{
    public class RoleModel : IdentityRole
    {
        public string RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
