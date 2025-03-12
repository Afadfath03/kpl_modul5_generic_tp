class Program {
    static void Main(string[] args) {
        Console.Write("Masukkan nama anda: ");
        string nama = Console.ReadLine();
        HaloGeneric.SapaUser(nama);

        Console.Write("\nMasukkan data dengan NIM anda : ");
        string nim = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}

class HaloGeneric {
    public static void SapaUser(string namauser) {
        Console.WriteLine("Halo user " + namauser);
    }
}

class DataGeneric<T> {
    T data;
    public DataGeneric(T data) {
        this.data = data;
    }

    public void PrintData() {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}