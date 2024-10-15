using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Vehiculos
{
    public sealed class Vehiculo
    {
        public Guid Id { get; private set; }
        public string? Modelo { get; private set; }
        public string? Vin { get; private set; }
        public string? Calle { get; private set; }
        public string? Departamento { get; private set; }
        public string? Provincia { get; private set; }
        public string? Ciudad { get; private set; }
        public string? Pais { get; private set; }
        public decimal Precio { get; private set; }
        public string? TipoMoneda { get; private set; }
        public string? Mantenimiento { get; private set; }
        public string? MantenimientoTipoMoneda { get; private set; }
        public DateTime? FechaUltimoAlquiler { get; private set; }
        public List<Accesorio> Accesorios { get; private set; } = new();
    }
}
