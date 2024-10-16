﻿using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Users.Events
{
    public sealed record UserCreateDomainEvent(Guid UserId) : IDomainEvent;

}
