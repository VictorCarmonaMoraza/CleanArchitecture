using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Abstractions
{
    public abstract class Entity
    {

        private readonly List<IDomainEvent> _domainEvents = new();
        protected Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; init; }

        //Obtener los eventos de dominio
        public IReadOnlyList<IDomainEvent> GetDomainsEvents()
        {
            return _domainEvents.ToList();
        }

        //Limpiar la lista de eventos de dominio
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        //Disparar eventos de dominio
        //Solo lo pueden implementar los hijso de esta clase
        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
