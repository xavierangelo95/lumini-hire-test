using System.Collections.Generic;

namespace Service.Configuration.DashboardData
{
    public class DashboardResponseColumnChartItem
    {
        public string City { get; set; }
        /// <summary>
        /// Pontuaction é um valor derivado de "ZIP" valor escolhido para gerar volume em grafico.
        /// </summary>
        public string Pontuaction { get; set; }
    }
}
