using Adaptador.Entidades;
using Adaptador.Interface;
using System.Collections.Generic;

namespace Adaptador.Clases
{
    public class ServicioEntidades: IInterface
    {
        ICrearListaSucursales ICrearListaSucursales { get; set; }

        public ServicioEntidades(ICrearListaSucursales _ICrearListaSucursales)
        {
            ICrearListaSucursales = _ICrearListaSucursales;
        }

        public List<Sucursal> ObtieneListSucursales()
        {
            List<Sucursal> lstSucursal = new List<Sucursal>();
            lstSucursal = ICrearListaSucursales.CrearListaEntidades();
            return lstSucursal;
        }
    }
}
