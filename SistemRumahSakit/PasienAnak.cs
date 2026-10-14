using System;

namespace SistemRumahSakit
{
    // buat derived class dari class Pasien tadi
    public class PasienAnak : Pasien
    {
        public PasienAnak(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
        {

        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} (pasien anak) sedang bermain sambil menunggu antrian diperiksa.");
        }

        public void Menangis()
        {
            Console.WriteLine($"{Nama} menangis karena takut disuntik.");
        }
    }
}