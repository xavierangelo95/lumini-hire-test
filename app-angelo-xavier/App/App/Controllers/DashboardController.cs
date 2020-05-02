using Microsoft.AspNetCore.Mvc;
using Service.Configuration.DashboardData;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("dashboard")]
    public class DashboardController : Controller
    {
        private IExternalDataService _externalDataService;

        public DashboardController(IExternalDataService externalDataService)
        {
            _externalDataService = externalDataService ?? throw new ArgumentNullException(nameof(FindController));
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("dashboard-pie")]
        public async Task<IActionResult> GetPieChart()
        {
            var result = await _externalDataService.Find("NULL");

            //var response = new DashResponse();

            var response = result.Hit.Hits.GroupBy(p => p.Source.STABBR)
                      .Select(g => new DashboardResponsePieChart()
                      {
                          Stabbr = g.Key,
                          Total = g.Count()
                      })
                      .ToList();

            return Json(response);

        }

        [Route("dashboard-column")]
        public async Task<IActionResult> GetColumnChart()
        {
            var result = await _externalDataService.Find("NULL",5);

            var list = new DashboardResponseColumnChartFull();
            list.Data = new List<DashboardResponseColumnChartItem>();

            foreach (var item in result.Hit.Hits)
            {
                list.Data.Add(new DashboardResponseColumnChartItem()
                {
                    City= item.Source.CITY,
                    Pontuaction = item.Source.ZIP
                });
            }

            return Json(list);

        }
    }
}