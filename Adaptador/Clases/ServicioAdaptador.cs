using Adaptador.Entidades;
using Adaptador.Interface;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Adaptador.Clases
{
    class ServicioAdaptador : IInterface
    {
        private ServicioJson servicioJson;

        public ServicioAdaptador(ServicioJson _servicioJson)
        {
            servicioJson = _servicioJson;
        }

        public List<Sucursal> ObtieneListSucursales()
        {
            List<Sucursal> lstSucursales = new List<Sucursal>();
            string clstSucursales = string.Empty;
            clstSucursales = servicioJson.ObtenerJsonSucursales();
            lstSucursales = JsonConvert.DeserializeObject<List<Sucursal>>(clstSucursales);
            return lstSucursales;
        }
    }
}
