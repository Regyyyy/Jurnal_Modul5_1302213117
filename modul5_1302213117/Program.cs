internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("NIM : 1302213117");
        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(13);
        database.AddNewData(02);
        database.AddNewData(21);
        database.PrintAllData();
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates = new List<DateTime>();
    public SimpleDataBase()
    {
        storedData = new List<T>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count;i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] 
                + ", yang disimpan pada waktu " + inputDates[i]);
        }
    }
}