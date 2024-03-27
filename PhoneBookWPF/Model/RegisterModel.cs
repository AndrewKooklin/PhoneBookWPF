using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace PhoneBookWPF.Model
{
    public class RegisterModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Role { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}
