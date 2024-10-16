using CleanArchitecture.Domain.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Alquileres
{
    public class PrecioService
    {
        public PrecioDetalle  CalcularPrecio(Vehiculo vehiculo, DateRange periodo)
        {
            //Con esto sabemos la moneda en la cual va a pagar el cliente
            var tipoMoneda = vehiculo.Precio!.TipoMoneda;

            //Precio por periodo
            var precioPorPeriodo = new Moneda(periodo.CantidadDias* vehiculo.Precio.Monto, tipoMoneda);

            decimal porcentageChange = 0;

            //Precio por accesorios
            foreach (var accesorio in vehiculo.Accesorios)
            {
                porcentageChange += accesorio switch
                {
                    Accesorio.AppleCar or Accesorio.AndroidCar => 0.5m,
                    Accesorio.AireAcondicinonado => 0.01m,
                    Accesorio.Mapas => 0.01m,
                    _ => 0
                };
            }

            var accesoriosCharges = Moneda.Zero(tipoMoneda);

            //Calcular el precio total de los accesorios
            if (porcentageChange > 0)
            {
                accesoriosCharges = new Moneda(precioPorPeriodo.Monto * porcentageChange, tipoMoneda);
            }

            var precioTotal = Moneda.Zero();
            precioTotal += precioPorPeriodo;

            if(!vehiculo!.Mantenimiento!.IsZero())
            {
                precioTotal += vehiculo.Mantenimiento;
            }

            precioTotal += accesoriosCharges;

            return new PrecioDetalle(precioPorPeriodo, vehiculo.Mantenimiento, accesoriosCharges, precioTotal);
        }
    }
}
