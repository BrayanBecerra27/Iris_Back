using IrisCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisBusiness.Interfaces
{
    public interface IJWTManagerBusiness
    {
        Tokens Authenticate(User usersdata);
    }
}
