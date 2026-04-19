namespace POOConcepts.Core;

public class BaseCommissionEmployee : CommissionEmployee
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
        if (salary < 500000)
        {
            throw new Exception($"The base: {salary:C2}, is less than the minimum salary ({500000:C2}).");
        }
        return salary;
    }
}
