using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DataAccess;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context context;

        public UpdateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = context.Products.Find(command.ProductId);
            values.Name = command.Name;
            values.Description = command.Description;
            values.Price = command.Price;
            values.Stock = command.Stock;
            values.Description = command.Description;
            context.SaveChanges();

        }
    }
}
