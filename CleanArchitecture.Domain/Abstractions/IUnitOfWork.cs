using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Abstractions;

public interface IUnitOfWork
{
    //Persistimos la data del usuario
    Task<int> SaveChangesAsync(CancellationToken cancellation = default);
}
