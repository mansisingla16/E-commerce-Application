using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    [ApiController, Authorize(Roles = "Admin"), Authorize, Route("api/admin/[controller]")]
    public class actorcontrollerBase
    {
    }
}