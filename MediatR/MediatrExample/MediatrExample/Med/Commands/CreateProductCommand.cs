﻿using MediatR;

namespace MediatrExample.Med.Commands
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                //sending to db using repository
                return Task.FromResult(Guid.NewGuid());
            }
        }
    }
}
