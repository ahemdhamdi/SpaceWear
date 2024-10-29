﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VogueApis.Errors;

namespace VogueApis.Controllers
{
    [Route("errors/{code}")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi =true)]
    public class ErrorsController : ControllerBase
    {
        public ActionResult Error (int code)
        {
            return NotFound(new ApiResponse(code));
        }
    }
}
