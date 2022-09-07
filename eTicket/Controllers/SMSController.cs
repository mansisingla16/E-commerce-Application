using eTicket.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sendsms.Model;
using Sendsms.Service;

namespace SendSMSWithTwilio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        private readonly ISmsService _smsService;
        private readonly AppDbContext _db;

        public SMSController(ISmsService smsService, AppDbContext db)
        {
            _smsService = smsService;
            _db = db;
        }

        [HttpPost("send")]
        public IActionResult Send(SENDsms dto)
        {
            /*var result = _smsService.Send(dto.MobileNumber, dto.Body);

            if (!string.IsNullOrEmpty(result.ErrorMessage))
                return BadRequest(result.ErrorMessage);

            return Ok(result);*/
            var result = _smsService.Send(dto.MobileNumber, dto.Body);
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                return BadRequest(result.ErrorMessage);
            else
            {
                _db.SENDsms.Add(dto);
                _db.SaveChanges();
                return Ok(result);
            }
        }
    }
}