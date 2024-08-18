using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "book"

            };

            return Task.FromResult(viewModel);
            // get product from repository
        }
    }
}
