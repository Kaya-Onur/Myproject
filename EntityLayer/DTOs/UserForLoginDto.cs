﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.DTOs
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
