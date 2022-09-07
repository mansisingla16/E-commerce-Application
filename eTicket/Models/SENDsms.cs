using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sendsms.Model
{
    public class SENDsms
    {
        [Key]
        public string MobileNumber { get; set; }
        public string Body { get; set; }
    }
}