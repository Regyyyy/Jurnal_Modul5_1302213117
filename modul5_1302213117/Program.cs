internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("NIM : 1302213117");
        Console.WriteLine("========Penjumlahan========");
        Penjumlahan angka = new Penjumlahan();
        Console.WriteLine(angka.JumlahTigaAngka<int>(13, 02, 21));
        Console.WriteLine("========Database========");
        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(13);
        database.AddNewData(02);
        database.AddNewData(21);
        database.PrintAllData();
    }
}
public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T input1, T input2, T input3)
    {
        dynamic angka1 = input1;
        dynamic angka2 = input2;
        dynamic angka3 = input3;
        return angka1 + angka2 + angka3;
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

