interface IMeterDistance
{
    public int KilometerToMeters(KilometerDistance distance);
}

class KilometerDistance
{
    public int Distance { get; set; }

    public KilometerDistance(int distance)
    {
        Distance = distance;
    }
}

class MeterAdapter : IMeterDistance
{
    const int k = 1000;
    public int KilometerToMeters(KilometerDistance distance)
    {
        return distance.Distance * k;
    }
}

class ClassWork()
{
    static void Main()
    {
        KilometerDistance distance = new(5);
        MeterAdapter adapter = new();
        Console.WriteLine(adapter.KilometerToMeters(distance));
    }
}
