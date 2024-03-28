using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWPF.Model
{
    public class UserWithRolesModel
    {
        public IdentityUser User { get; set; }

        public List<string> Roles { get; set; }
    }
}
