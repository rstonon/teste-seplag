﻿using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pessoas")]
    public class PessoasController : Controller
    {

        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
