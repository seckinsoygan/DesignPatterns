using ConsoleApp.TemplatePattern;

public class Program
{
    private static void Main(string[] args)
    {
        NetflixPlans plan1 = new BasicPlan();
        plan1.PlanType("BasicPlan");
        plan1.Resoulution("480p");
        plan1.CountPerson(1);
        plan1.Price(50.0);
        plan1.Content("Çocuk İçeriği");

        plan1.CreatePlan();

        NetflixPlans plan2 = new StandardPlan();
        plan2.PlanType("StandardPlan");
        plan2.Resoulution("1080p");
        plan2.CountPerson(4);
        plan2.Price(100.0);
        plan2.Content("Tüm İçerik");

        plan2.CreatePlan();

    }
}