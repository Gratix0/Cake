namespace CakeOrder;

internal class countPrice
{
    public static int OnePun, TwoPun, ThreePun, FourPun, FivePun, SixPun, SevenPun;
    public static int Result;

    public countPrice(int onePunParam, int twoPunParam, int threePunParam, int fourPunParam, int fivePunParam, int sixPunParam, int sevenPunParam)
    {
        OnePun = onePunParam;
        TwoPun = twoPunParam;
        ThreePun = threePunParam;
        FourPun = fourPunParam;
        FivePun = fivePunParam;
        SixPun = sixPunParam;
        SevenPun = sevenPunParam;
    }
    
    public static void CountingResult()
    {
        Result = OnePun + TwoPun + ThreePun + FourPun + FivePun + SixPun + SevenPun;
        Console.WriteLine(Result);
    }
}