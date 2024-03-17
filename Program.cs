public class DataGeneric<T>
{
    public T Data { get; set; }
    public DataGeneric(T data) 
    {
        Data = data;    
    }

    public void printdata()
    {
        Console.WriteLine("Data yang tersimpan adalah: " +  Data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> stringData = new DataGeneric<string>("1302223124");
        stringData.printdata();
    }
}