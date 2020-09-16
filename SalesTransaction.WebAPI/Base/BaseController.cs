using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SalesTransaction.WebAPI.Areas
  [Produces("application/json")]
  [EnableCors("AllowOrigin"), Route("api/[controller]/[action]/{id?}")]
public class BaseController
    {

    }
}
