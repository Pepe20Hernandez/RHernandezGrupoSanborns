using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class ConsultasController : Controller
    {
        // GET: Consultas
        public ActionResult GetProductosDescontinuados()
        {
            ML.Result result = BL.Consultas.GetProductosDescontinuados();
            ML.Products products = new ML.Products();
            if (result.Correct)
            {
                products.Productos = result.Objects;
            }
            else
            {
                ViewBag.Mensaje = result.ErrorMessage;
            }
            return View(products);
        }

        public ActionResult GetPromedioPrecioUnitarioArticulos()
        {
            ML.Result result = BL.Consultas.GetPromedioPrecioUnitarioArticulos();
            ML.Products products = new ML.Products();
            if (result.Correct)
            {
                products.Productos = result.Objects;
            }
            else
            {
                ViewBag.Mensaje = result.ErrorMessage;
            }
            return View(products);
        }


        public ActionResult GetReporte()
        {
            ML.Reporte reporte = new ML.Reporte();

            reporte.Año = (reporte.Año == null) ? "" : reporte.Año;

            ML.Result result = BL.Consultas.GetReporte(reporte);
            
            if (result.Correct)
            {
                reporte.Reportes = result.Objects;
            }
            else
            {
                ViewBag.Mensaje = result.ErrorMessage;
            }
            return View(reporte);
        }

        [HttpPost]
        public ActionResult GetReporte(string reportes)
        {
            ML.Reporte reporte = new ML.Reporte();

            reporte.Año = reportes;

            ML.Result result = BL.Consultas.GetReporte(reporte);

            if (result.Correct)
            {
                reporte.Reportes = result.Objects;
            }
            else
            {
                ViewBag.Mensaje = result.ErrorMessage;
            }
            return View(reporte);
        }
    }
}