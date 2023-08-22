using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DataAccess;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class DeleteProductCommandHandler
    {
        private readonly Context context;

        public DeleteProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(DeleteProductCommand command)
        {
            var values = context.Products.Find(command.ProductID);
            context.Products.Remove(values);
            context.SaveChanges();
        }
    }
}
