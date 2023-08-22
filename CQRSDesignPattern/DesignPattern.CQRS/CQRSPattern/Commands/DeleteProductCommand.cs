namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class DeleteProductCommand
    {
        public int ProductID { get; set; }

        public DeleteProductCommand(int productID)
        {
            ProductID = productID;
        }
    }
}
