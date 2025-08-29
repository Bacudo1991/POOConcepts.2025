namespace POOConceptsCore;

public abstract class Employee
{
    public int Id { get; set; }
    public int Firstname { get; set; }
    public int Lastname { get; set; }
    public bool IsActive { get; set; }
    public Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;


    public abstract decimal GetValueToPay();

    public override string ToString() =>
        $"{Id}\t{Firstname} {Lastname}\n\t" +
        $"Hire date..: {HireDate}\n\t" + 
        $"Salary.....: {GetValueToPay():C2}";
    
    
}