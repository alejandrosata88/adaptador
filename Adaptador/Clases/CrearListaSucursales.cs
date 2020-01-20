using System.Collections.Generic;
using Adaptador.Entidades;
using Adaptador.Interface;

namespace Adaptador.Clases
{
    class CrearListaSucursales : ICrearListaSucursales
    {
        public List<Sucursal> CrearListaEntidades()
        {
            List<Sucursal> lstSucursal = new List<Sucursal>();
            lstSucursal.Add(new Sucursal
            {
                iIdSucursal = 1,
                cNombre = "Sucursal_Altabrisa"
            });
            lstSucursal.Add(new Sucursal
            {
                iIdSucursal = 2,
                cNombre = "Sucursal_Centro"
            });
            return lstSucursal;
        }
    }
}
