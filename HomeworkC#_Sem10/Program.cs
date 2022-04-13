//Отдельно прописываем метод непосредственно перевода из двоичного представления в десятичное.
int Transform(string binary)
{
    int decvis = 0;
    int n = binary.Length;
    for (int i = 0; i < n; i++)
    {
        //string prom = "";
        decvis = decvis + Convert.ToInt32(Convert.ToString(binary[i]))* Convert.ToInt32(Math.Pow(2, (n-1-i)));
    }
    return decvis;
}

int[] TransformArray(int[] data, int[] info)
{
    int start = 0, end = info[0];
    int[] decvisarray = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {
        string binary = "";
        for (int j = start; j < end; j++)
        {
            binary = binary + Convert.ToString(data[j]);
        }
        decvisarray[i] = Transform(binary);
        if((i + 1) == info.Length) break;
        start = start + info[i];
        end = end + info[i+1];
    }
    Console.WriteLine("[{0}]", string.Join(", ", decvisarray));
    return decvisarray;
}

int[] info = {2, 3, 3, 1 };
int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
TransformArray(data, info);
