namespace ConsoleApp.TemplatePattern
{
    public class StandardPlan : NetflixPlans
    {
        public override string Content(string Content)
        {
            return Content;
        }

        public override int CountPerson(int CountPerson)
        {
            return CountPerson;
        }

        public override string PlanType(string PlanType)
        {
            return PlanType;
        }

        public override double Price(double Price)
        {
            return Price;
        }

        public override string Resoulution(string Resoulution)
        {
            return Resoulution;
        }
    }
}
