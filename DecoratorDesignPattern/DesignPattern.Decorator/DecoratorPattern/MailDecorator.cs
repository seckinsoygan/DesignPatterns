using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        private readonly INotifier _notifier;
        Context context = new Context();
        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }

        public void SendMailNotify(Notifier notifier)
        {
            notifier.NotiferSubject = "Günlük Sabah Toplantısı";
            notifier.NotifierCreater = "Scrum Master";
            notifier.NotifierChannel = "Gmail-Outlook";
            notifier.NotifierType = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
        }
    }
}
