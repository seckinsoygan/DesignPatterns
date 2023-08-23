using DesignPattern.Observer.DataAccess;
using DesignPattern.Observer.Entities;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        private readonly Context context;

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser user)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = user.Name + " " + user.Surname,
                Content = "Dergi Bültenimize kayıt olduğunuz için teşekkür ederiz."
            });
            context.SaveChanges();
        }
    }
}
