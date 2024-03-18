class program
{
    class Penjumlahan<T>
    {
        public  void JumlahTigaAngka<T>(List<T> input)
        {
            dynamic N = 0.0;

            for (int i = 0; i < input.Count; i++)
            {
                N = N + input[i];
            }
            Console.WriteLine("Hasil Penjumlahan = " + N);
        }
    }

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
        Penjumlahan<double> jumlah = new Penjumlahan<double>();
        List<double> I = new List<double>();
        I.Add(13);
        I.Add(2);
        I.Add(28);
        jumlah.JumlahTigaAngka(I);

        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13.0);
        data.AddNewData(2.0);
        data.AddNewData(28.0);

        data.PrintAllData();
    }
}

