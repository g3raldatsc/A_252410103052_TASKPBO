using System;

namespace SistemRumahSakit
{
    // derived class dari Orang
    public class TenagaMedis : Orang
    {
        private string spesialisasi;

        // ini properti spesialisasi pake genset
        public string Spesialisasi
        {
            get 
            { 
                return spesialisasi;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    spesialisasi = value;
                }
                else
                {
                    Console.WriteLine("Spesialisasi tidak boleh kosong.");
                }
            }
        }

        // panggil constructor Parent pakai 'base'
        public TenagaMedis(string nama, int umur, string spesialisasi) : base(nama, umur)
        {
            Spesialisasi = spesialisasi;
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} (tenaga medis) sedang bertugas di rumah sakit.");
        }

        public void CekSpesialis()
        {
            Console.WriteLine($"Spesialisasi {Nama}: {Spesialisasi}");
        }
    }
}