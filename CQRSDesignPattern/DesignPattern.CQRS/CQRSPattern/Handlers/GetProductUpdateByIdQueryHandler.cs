using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DataAccess;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            this.context = context;
        }

        public GetProductUpdateByIdQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var values = context.Products.Find(query.ProductId);
            return new GetProductUpdateByIdQueryResult
            {
                Description = values.Description,
                ProductId = values.ProductId,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock
            };
        }
    }
}
