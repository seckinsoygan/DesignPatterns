using DesignPattern.Observer.DataAccess;
using DesignPattern.Observer.Entities;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        private readonly Context context;

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser user)
        {
            context.UserProcess.Add(new UserProcess
            {
                NameSurname = user.Name + " " + user.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim Dergimizin Mart sayısı 1 Martta evinize ulaştırılacaktır. Bilginize."
            });
            context.SaveChanges();
        }
    }
}
