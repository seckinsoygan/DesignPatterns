using DesignPattern.ChainOfResponsibility.DataAccess;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {

        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            AppDbContext context = new AppDbContext();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşterinin talep ettiği tutar ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para çekme tutarı veznedarın ödeyeceği limiti aştığı için , işlem şube müdür yardımcısına yönlendirildi. ";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
            throw new NotImplementedException();
        }
    }
}
