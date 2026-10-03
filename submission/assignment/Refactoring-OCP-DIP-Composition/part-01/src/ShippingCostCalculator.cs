namespace RefactoringLab;

//public class ShippingCostCalculator
//{
//    public decimal Calculate(string carrier, decimal weightKg)
//    {
//        switch (carrier)
//        {
//            case "Aramex":
//                return weightKg * 12m;
//            case "FedEx":
//                return weightKg * 15m;
//            case "DHL":
//                return weightKg * 18m;
//            default:
//                throw new ArgumentException($"Unknown carrier: {carrier}");
//        }
//    }
//}

public class ShippingCostCalculator
{
    private readonly IShippingCostCalculator _iShippingCostCalculator;

    public ShippingCostCalculator(IShippingCostCalculator iShippingCostCalculator)
    {
        _iShippingCostCalculator = iShippingCostCalculator;
    }
    public decimal Calculate(decimal weightKg)
    {
        return _iShippingCostCalculator.Calculate(weightKg);
    }

}

public interface IShippingCostCalculator
{
   public decimal Calculate(decimal weightKg);
}

public class Aramex : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}

public class FedEx : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}
public class DHL : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}
public class Bosta : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 10m;
    }
}

