namespace POOConceptsCore;

public class SalaryEmployee : Employee
{
    private const decimal MINIMUM_SALARY = 1500000;
    private decimal _salary;

    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    public override decimal GetValueToPay() => Salary;

    public override string ToString() => $"{base.ToString()}\n\t" + $"Salary.........: {GetValueToPay(),20:C2}";   
    

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < MINIMUM_SALARY)
        {
            throw new Exception($"The salary: {salary:C2}, is less than the minimum salary ({MINIMUM_SALARY:C2})");
        }
        return salary;
    }
}