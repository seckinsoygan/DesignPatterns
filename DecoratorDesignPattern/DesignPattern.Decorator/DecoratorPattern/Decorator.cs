using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class Decorator : INotifier
    {
        private readonly INotifier _notifier;

        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void CreateNotify(Notifier notifier)
        {
            notifier.NotifierCreater = "Admin";
            notifier.NotiferSubject = "Toplantı";
            notifier.NotifierType = "Public";
            notifier.NotifierChannel = "Whatsapp";
            _notifier.CreateNotify(notifier);
        }
    }
}
