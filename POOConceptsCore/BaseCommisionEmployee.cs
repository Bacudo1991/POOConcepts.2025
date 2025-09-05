namespace POOConceptsCore;

public class BaseCommisionEmployee : CommisionEmployee
{
    private decimal _salary;
    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 300000)
        {
            throw new Exception($"The base: {salary:C2}, is less than the minimum salary ({300000:C2}).");
        }
        return salary;
    }
}