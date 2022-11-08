using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SeerBI.Web.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SeerBIWebUser class
public class SeerBIWebUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string category { get; set; }
    public string profession { get; set; }

}

