using Adaptador.Entidades;
using Adaptador.Interface;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Adaptador.Clases
{
    class ServicioJson
    {
        ICrearListaSucursales ICrearListaSucursales { get; set; }

        public ServicioJson(ICrearListaSucursales _ICrearListaSucursales)
        {
            ICrearListaSucursales = _ICrearListaSucursales;
        }

        public string ObtenerJsonSucursales()
        {
            string cJson = string.Empty;
            List<Sucursal> lstSucursal = new List<Sucursal>();
            lstSucursal = ICrearListaSucursales.CrearListaEntidades();
            cJson = JsonConvert.SerializeObject(lstSucursal);
            return cJson;
        }
    }
}
