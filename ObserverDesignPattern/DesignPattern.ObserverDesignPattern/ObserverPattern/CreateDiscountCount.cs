using DesignPattern.Observer.DataAccess;
using DesignPattern.Observer.Entities;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateDiscountCount : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        private readonly Context context;

        public CreateDiscountCount(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser user)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "DERGIMART",
                DiscountAmount = 20,
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
