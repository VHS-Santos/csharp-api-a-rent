using ARent.Domain.Arguments.Deliveryman;
using ARent.Domain.Interfaces.Repositories;
using ARent.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARent.Domain.Services
{
    public class ServiceDeliveryman : IServiceDeliveryman
    {
        private readonly IRepositoryDeliveryman _repositoryDeliveryman;

        public ServiceDeliveryman(IRepositoryDeliveryman repositoryDeliveryman)
        {
            _repositoryDeliveryman = repositoryDeliveryman;
        }

        public AddDeliverymanResponse AddDeliveryman(AddDeliverymanRequest request)
        {
            Guid id = _repositoryDeliveryman.AddDeliveryman(request);

            return new AddDeliverymanResponse() { id = id, Message = "Operação realizada!!" };
        }
    }
}
