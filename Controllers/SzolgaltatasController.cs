using KutyakozmetikaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutyakozmetikaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzolgaltatasController : ControllerBase
    {

        private kutyakozmetikaContext context;

        public SzolgaltatasController(kutyakozmetikaContext kutyakozmetikaContext)
        {
            context = kutyakozmetikaContext;
        }
    }
}
