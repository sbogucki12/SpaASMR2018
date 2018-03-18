using SpaASMR2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpaASMR2018.Controllers.api
{
    public class ErrorsController : ApiController
    {
        private SpaAsmrDbContext _context;

        public ErrorsController()
        {
            _context = new SpaAsmrDbContext();
        }

        [Route("api/errors/submit")]
        [HttpPost]
        public ErrorInput Submit([FromBody] ErrorInput errorInput)
        {
            var errorToInput = new ErrorInput
            {
                UserName = errorInput.UserName,
                UserEmail = errorInput.UserEmail,
                UserInput = errorInput.UserInput
            };

            _context.ErrorInputs.Add(errorToInput);
            _context.SaveChanges();

            return _context.ErrorInputs.ToList().Last();
        }

    }
}
