public class HaloGeneric
{
    public void SapaUser(string x)
    {
        Console.WriteLine("Halo User " + x);
    }
}

public class program
{
    static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        string x = "Daffa";
        haloGeneric.SapaUser(x);
    }
}