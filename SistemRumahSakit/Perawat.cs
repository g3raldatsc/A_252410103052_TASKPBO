using System;

namespace SistemRumahSakit
{
    public class Perawat : TenagaMedis
    {
        public Perawat(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi)
        {

        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Perawat {Nama} sedang membantu dokter dan merawat pasien.");
        }

        public void CekPasien()
        {
            Console.WriteLine($"Perawat {Nama} sedang mengecek kondisi pasien di bangsal.");
        }
    }
}