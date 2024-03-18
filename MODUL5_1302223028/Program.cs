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

    private static void Main(String[] args)
    {
        Penjumlahan<double> jumlah = new Penjumlahan<double>();
        List<double> I = new List<double>();
        I.Add(13);
        I.Add(2);
        I.Add(28);
        jumlah.JumlahTigaAngka(I);
    }
}

