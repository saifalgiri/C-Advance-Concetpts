<Query Kind="Program" />

class Program
{
    static void Main(string[] args)
    {
        Counter c = new Counter();
        c.ThresholdReached += c_ThresholdReached;

        Console.WriteLine("press 'a' key to increase total");
        while (Console.ReadKey(true).KeyChar == 'a')
        {
            Console.WriteLine("adding one");
            c.Add(1);
        }
    }

    static void c_ThresholdReached(object sender, EventArgs e)
    {
        Console.WriteLine("The threshold was reached.");
        Environment.Exit(0);
    }
}

class Counter
{
    private int threshold;
    private int total;
    public event EventHandler ThresholdReached;

    public void Add(int x)
    {

        OnThresholdReached(EventArgs.Empty);
        
    }

    protected virtual void OnThresholdReached(EventArgs e)
    {
        EventHandler handler = ThresholdReached;
        if (handler != null)
        {
            handler(this, e);
        }
    }


}