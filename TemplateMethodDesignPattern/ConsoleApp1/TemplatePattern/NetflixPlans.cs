namespace ConsoleApp.TemplatePattern
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            var a = PlanType(string.Empty);
            var b = CountPerson(0);
            var c = Price(0);
            var d = Resoulution(string.Empty);
            var e = Content(string.Empty);

            Console.WriteLine($"{a} - {b} - {c} - {d} - {e} ");
        }
        public abstract string PlanType(string PlanType);
        public abstract int CountPerson(int CountPerson);
        public abstract double Price(double Price);
        public abstract string Resoulution(string Resoulution);
        public abstract string Content(string Content);
    }
}
