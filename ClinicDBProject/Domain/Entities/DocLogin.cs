﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DocLogin
    {
        [Key]
        public int LoginId { get; set; }
        public string Login { get; set; }
        public virtual Doctor Doctor { get; set; }
        public string Password { get; set; }
    }
}