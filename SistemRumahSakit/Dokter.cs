using System;

namespace SistemRumahSakit
{
    public class Dokter : TenagaMedis
    {
        public Dokter(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi)
        {

        }

        public override void Aktivitas()
        {
            Console.WriteLine($"dr. {Nama} sedang memeriksa pasien di ruang praktik.");
        }

        public void Diagnosa()
        {
            Console.WriteLine($"dr. {Nama} ({Spesialisasi}) sedang mendiagnosa penyakit pasien.");
        }
    }
}