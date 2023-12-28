using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Consultas
    {

        public static ML.Result GetProductosDescontinuados()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection())
                {
                    context.ConnectionString = DL.Conexion.GetConnectionString();
                    context.Open();

                    string query = "GetProductosDescontinuados";

                    using (SqlCommand cmd = new SqlCommand(query,context))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable dataTable = new DataTable();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                        sqlDataAdapter.Fill(dataTable);

                        if(dataTable.Rows.Count > 0 )
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow item in dataTable.Rows)
                            {
                                ML.Products products = new ML.Products();

                                products.ProductID = int.Parse(item[0].ToString());
                                products.ProductName = item[1].ToString();
                                products.Suppliers = new ML.Suppliers();
                                products.Suppliers.SupplierID = int.Parse(item[2].ToString());
                                products.Categories = new ML.Categories();
                                products.Categories.CategoryID = int.Parse(item[3].ToString());
                                products.QuantityPerUnit = item[4].ToString();
                                products.UnitPrice = double.Parse(item[5].ToString());
                                products.UnitsinStock = int.Parse(item[6].ToString());
                                products.UnitsOnOrder = int.Parse(item[7].ToString());
                                products.ReorderLevel = int.Parse(item[8].ToString());
                                products.Discontinued = bool.Parse(item[9].ToString());

                                result.Objects.Add(products);

                            }

                            result.Correct = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = "Ocurrio un error en la consulta" + result.Ex;
                //throw;
            }

            return result;
        }

        public static ML.Result GetPromedioPrecioUnitarioArticulos()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection())
                {
                    context.ConnectionString = DL.Conexion.GetConnectionString();
                    context.Open();

                    string query = "GetPromedioPrecioUnitarioArticulos";

                    using (SqlCommand cmd = new SqlCommand(query, context))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable dataTable = new DataTable();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                        sqlDataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow item in dataTable.Rows)
                            {
                                ML.Products products = new ML.Products();

                                products.ProductID = int.Parse(item[0].ToString());
                                products.ProductName = item[1].ToString();
                                products.Categories = new ML.Categories();
                                products.Categories.CategoryID = int.Parse(item[2].ToString());
                                products.Categories.CategoryName = item[3].ToString();
                                products.UnitPrice = double.Parse(item[4].ToString());                           

                                result.Objects.Add(products);

                            }
                            result.Correct = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = "Ocurrio un error en la consulta" + result.Ex;
                //throw;
            }

            return result;
        }

        public static ML.Result GetReporte(ML.Reporte reporteParemetro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection())
                {
                    context.ConnectionString = DL.Conexion.GetConnectionString();
                    context.Open();

                    string query = "GetReporte";

                    using (SqlCommand cmd = new SqlCommand(query, context))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@año", reporteParemetro.Año);

                        DataTable dataTable = new DataTable();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                        sqlDataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow item in dataTable.Rows)
                            {
                                ML.Reporte reporte = new ML.Reporte();

                                reporte.FechaOrden = item[0].ToString();
                                reporte.CompanyNameClient = item[1].ToString();
                                reporte.OrderID = int.Parse(item[2].ToString());
                                reporte.Quantity = int.Parse(item[3].ToString());
                                reporte.ProductName = item[4].ToString();
                                reporte.CompanyNameSupplier = item[5].ToString();
                                reporte.City = item[6].ToString();

                                result.Objects.Add(reporte);

                            }
                            result.Correct = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = "Ocurrio un error en la consulta" + result.Ex;
                //throw;
            }

            return result;
        }

        public static ML.Result Operaciones()
        {
            ML.Result result = new ML.Result();
            string f = "hola";
            return result;
        }
    }
}
