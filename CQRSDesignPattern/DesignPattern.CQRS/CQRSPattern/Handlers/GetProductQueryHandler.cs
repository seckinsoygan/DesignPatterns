using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DataAccess;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context context;

        public GetProductQueryHandler(Context context)
        {
            this.context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = context.Products.Select(x => new GetProductQueryResult
            {
                ID = x.ProductId,
                Price = x.Price,
                ProductName = x.Name,
                Stock = x.Stock
            }).ToList();
            return values;
        }
    }
}
