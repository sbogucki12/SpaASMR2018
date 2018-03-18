using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class ErrorInput
    {
        public int? Id { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }

        [MaxLength]
        public string UserInput { get; set; }
    }
}