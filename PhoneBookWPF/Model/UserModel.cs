using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWPF.Model
{
    public class UserModel : IdentityUser
    {
        public override string Id { get; set; }

        public override string Email { get; set; }

        public string Password { get; set; }
    }
}
