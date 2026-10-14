using System;
using System.Runtime.InteropServices.Marshalling;

namespace SistemRumahSakit
{
    // derived class dari Pasien
    public class PasienDewasa : Pasien
    {
        public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
        {

        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} (pasien dewasa) sedang mengisi formulir pendaftaran.");
        }

        public void Konsultasi()
        {
            Console.WriteLine($"{Nama} berkonsultasi tentang keluhan: {Keluhan}.");
        }
    }
}