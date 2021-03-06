﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManagementSystem.Models
{
    public class Qualifications
    {
        public int Id { get; set; }
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public byte English { get; set; }
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public byte Leadership { get; set; }
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public byte Communication { get; set; }
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public byte Creativity { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}