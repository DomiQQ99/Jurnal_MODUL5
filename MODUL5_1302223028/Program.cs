class Program
{
    public class SimpleDataBase<T>
    {
        List<T> storeData;
        List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storeData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storeData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData() 
        {
            for (int i = 0; i < storeData.Count; i++)
            {
                Console.WriteLine("Data " + (i+1) + " Berisi " + storeData[i] + " Yang Disimpan Pada Waktu " + inputDates[i]);
            }
        }
    }
    public static void Main(string[] args)
    {
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13.0);
        data.AddNewData(2.0);
        data.AddNewData(28.0);

        data.PrintAllData();
    }

}
