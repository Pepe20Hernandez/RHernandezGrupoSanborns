using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Reporte
    {
        public string FechaOrden { get; set; }
        public string CompanyNameClient { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string CompanyNameSupplier { get; set; }
        public string City { get; set; }
        public string Año { get; set; }
        public List<object> Reportes { get; set; }
    }
}
