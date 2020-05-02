
using App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Configuration;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("find")]
    public class FindController : Controller
    {
        private IExternalDataService _externalDataService;

        public FindController(IExternalDataService externalDataService)
        {
            _externalDataService = externalDataService ?? throw new ArgumentNullException(nameof(FindController));
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet("{textToFind:maxlength(80)?}")]
        public async Task<IActionResult> Get([FromRoute] string textToFind)
        {
            if (textToFind == null)
                return BadRequest("Parametro inválido");

            var result = await _externalDataService.Find(textToFind);

            var response = new FindResponse();
            response.Data = new List<ExternalDataResponseResultItem>();

            foreach (var item in result.Hit.Hits)
                response.Data.Add(item.Source);

            var x = response.Data.GroupBy(p => p.CITY)
                      .Select(g => new
                      {
                          REGION = g.Key,
                          Count = g.Count()
                      })
                      .ToList();

            return Json(response);

        }
    }
}