﻿public class KodePos
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };
    public static int getKodePos(Kelurahan KELURAHAN)
    {
        int[] kodepos = { 40266, 40287, 40256, 40287, 40286, 40272, 40274, 40273, 40272, 40274, 40273 };
        return kodepos[(int)KELURAHAN];
    }
}




