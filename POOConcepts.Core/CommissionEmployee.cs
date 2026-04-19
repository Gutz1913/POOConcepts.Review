namespace POOConcepts.Core;

public class CommissionEmployee : Employee
{
    private float _commissionPercent;
    private decimal _sales;

    public float CommissionPercent
    {
        get => _commissionPercent;
        set => _commissionPercent = ValidateCommissionPercent(value);
    }

    public decimal Sales 
    {
        get => _sales;
        set => _sales = ValidateSales(value); 
    }

    public override decimal GetValueToPay() => Sales * (decimal)CommissionPercent;

    private decimal ValidateSales(decimal sales)
    {
        if (sales <= 0)
        {
            throw new Exception($"The sales: {sales:C2}, are less or equals than 0.");
        }
        return sales;
    }

    private float ValidateCommissionPercent(float commissionPercent)
    {
        if (commissionPercent < 0 || commissionPercent > 100)
        {
            throw new Exception($"The commission percent: {commissionPercent:P2} is invalid.");
        }
        return commissionPercent;
    }

}
