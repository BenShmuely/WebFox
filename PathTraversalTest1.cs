using Microsoft.AspNetCore.Mvc;
using System;

namespace WebFox.Controllers
{
    public class PathTraversalTest1 : ControllerBase
    {
        [HttpGet("{path}")]
        public void DOPathTrav(String path)
        {
            System.IO.File.Delete(path);
        }


    }
}
