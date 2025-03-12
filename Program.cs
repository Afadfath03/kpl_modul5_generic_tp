class Program {
    static void Main(string[] args) {
        Console.Write("Masukkan nama anda: ");
        string nama = Console.ReadLine();
        HaloGeneric.SapaUser(nama);
    }
}

class HaloGeneric {
    public static void SapaUser(string namauser) {
        Console.WriteLine("Halo user " + namauser);
    }
}