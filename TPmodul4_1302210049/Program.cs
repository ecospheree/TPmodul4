public class KodePos
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };
    public static int getKodePos(Kelurahan KELURAHAN)
    {
        int[] kodepos = { 40266, 40287, 40256, 40287, 40286, 40272, 40274, 40273, 40272, 40274, 40273 };
        return kodepos[(int)KELURAHAN];
    }
}

public class DoorMachine
{
    enum state { PintuTerkunci, PintuTerbuka };
    public static void Main(string[] args)
    {
        Console.WriteLine("Kelurahan " + KodePos.Kelurahan.Samoja + " KodePos " + KodePos.getKodePos(KodePos.Kelurahan.Samoja));
        Console.WriteLine("Kode Perintah : Kunci_Pintunya, Buka_Pintunya");

        state KondisiPintu = state.PintuTerkunci;
        string Perintah = "Kunci_Pintunya";

        while (Perintah == "Kunci_Pintunya" || Perintah == "Buka_Pintunya")
        {
            Console.WriteLine(KondisiPintu);
            Console.Write("Masukkan Perintah : ");
            Perintah = Console.ReadLine();
            if (Perintah == "Buka_Pintunya")
            {
                KondisiPintu = state.PintuTerbuka;
            }
            else if (Perintah == "Kunci_Pintunya")
            {
                KondisiPintu = state.PintuTerkunci;
            }
        }
    }
}



