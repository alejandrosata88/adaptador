using Adaptador.Clases;
using Adaptador.Entidades;
using Adaptador.Interface;
using System;
using System.Collections.Generic;

namespace Adaptador.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            List<Sucursal> lstSucursal = new List<Sucursal>();
            ICrearListaSucursales ICrearListaSucursales = new CrearListaSucursales();

            Console.WriteLine("Obtiene sucursales como entidad:");
            IInterface Iinterfacce = new ServicioEntidades(ICrearListaSucursales);
            lstSucursal = Iinterfacce.ObtieneListSucursales();
            ImprimirMensaje(lstSucursal);

            Console.WriteLine("Obtiene sucursales por json:");
            ServicioJson ServicioJson = new ServicioJson(ICrearListaSucursales);
            Iinterfacce = new ServicioAdaptador(ServicioJson);
            lstSucursal=Iinterfacce.ObtieneListSucursales();
            ImprimirMensaje(lstSucursal);

            Console.ReadLine();
        }

        public void ImprimirMensaje(List<Sucursal> _lstSucursal)
        {
            foreach(Sucursal sucursal in _lstSucursal)
            {
                Console.WriteLine(string.Format("Sucursale número: {0} de nombre: {1}", sucursal.iIdSucursal, sucursal.cNombre));
            }
        }
    }
}
