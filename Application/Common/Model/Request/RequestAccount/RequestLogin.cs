﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Application.Common.Model.Request.RequestAccount
{
    public class RequestLogin
    {
        [Required] public string UserName { get; set; }

        [Required] public string Password { get; set; }
    }
}
