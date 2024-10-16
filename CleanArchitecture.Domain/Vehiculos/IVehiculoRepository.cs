using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Vehiculos;

public interface IVehiculoRepository
{
    //Busqueda de un vehiculo por su id
    Task<Vehiculo?> GetByIdAsync(Guid id, CancellationToken cancellation = default);
}
