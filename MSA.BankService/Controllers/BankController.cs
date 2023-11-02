using Microsoft.AspNetCore.Mvc;
using MSA.Common.Contracts.Domain;
using MassTransit;
using MSA.Common.Contracts.Domain.Events.Product;
using Microsoft.AspNetCore.Authorization;

namespace MSA.BankService.Controllers
{
    [ApiController]
    [Route("v1/bank")]
    [Authorize]
    public class BankController : ControllerBase
    {

        public BankController()
        {
        }

    }
}