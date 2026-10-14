using System;

namespace SistemRumahSakit
{
    // lanjut ke derived classnya yaitu nge-inheritance si class Orang ke Pasien
    public class Pasien : Orang
    {
        private string keluhan;

        public string Keluhan
        {
            get
            {
                return keluhan;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    keluhan = value;
                }
                else
                {
                    Console.WriteLine("Keluhan tidak boleh kosong.");
                }
            }
        }

        // panggil constructor parent clas tadi pakai base
        public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
        {
            Keluhan = keluhan;
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} (pasien) sedang menunggu pemeriksaan.");
        }

        public void CekKeluhan()
        {
            Console.WriteLine($"Keluhan {Nama}: {Keluhan}");
        }
    }
}