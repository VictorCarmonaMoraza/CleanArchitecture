using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Users;

public interface IUserRepository
{
    //Obtener usuario por Id
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellation = default);

    //Crear un usuario
    void Add(User user);
}
