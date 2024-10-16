using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Alquileres.Enum;

namespace CleanArchitecture.Domain.Alquileres;

public sealed class Alquiler : Entity
{
    public Alquiler(Guid id) : base(id)
    {
    }

    public AlquilerStatus Status { get; private set; }


}
