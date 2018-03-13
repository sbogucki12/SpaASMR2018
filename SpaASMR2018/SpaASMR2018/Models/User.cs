using AuthenticationCode.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaASMR2018.Models
{
    public class User
    {
        public int Id { get; set; }
        public List<Video> Videos { get; set; }        
        public Video Video { get; set; }
    }
}