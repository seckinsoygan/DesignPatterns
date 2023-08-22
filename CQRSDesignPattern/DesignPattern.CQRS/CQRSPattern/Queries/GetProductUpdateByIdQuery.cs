namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public int ProductId { get; set; }

        public GetProductUpdateByIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
