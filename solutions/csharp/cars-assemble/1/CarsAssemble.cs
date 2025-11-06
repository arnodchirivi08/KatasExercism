static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
          0 => 0.0,
          >= 1 and <= 4 => 1.0,
          >= 5 and <= 8 => 0.9,
          9 => 0.8,
          10 => 0.77
        };
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        var baseProductionRate = 221;
        var nominalProduction = speed * baseProductionRate;
        return nominalProduction * AssemblyLine.SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {        
        return (int)(AssemblyLine.ProductionRatePerHour(speed) / 60);
    }
}
