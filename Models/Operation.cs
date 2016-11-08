using System;
using BasisMap.Interfaces;

namespace BasisMap.Models
{
    public class Operation : IOperationTransient, 
        IOperationScoped, 
        IOperationSingleton, 
        IOperationSingletonInstance
    {
        public Operation():this(Guid.NewGuid())
        {
        }
        public Operation(Guid id)
        {
            OperationId = id;
        }
        public Guid OperationId { get; private set; }
    }
}