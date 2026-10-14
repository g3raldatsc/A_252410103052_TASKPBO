using System;
using System.Collections.Generic;

namespace SistemRumahSakit
{
    public class RumahSakit
    {
        // list orang yang diprivate agar hanya bisa diubah pakai method
        private List<Orang> daftarOrang = new List<Orang>();

        public void TambahOrang(Orang orang)
        {
            if (orang == null)
            {
                Console.WriteLine("Data orang tidak boleh kosong.");
                return;
            }

            daftarOrang.Add(orang);
            Console.WriteLine($"{orang.Nama} berhasil ditambahkan ke rumah sakit.");
        }

        public void DaftarOrang()
        {
            if (daftarOrang.Count == 0)
            {
                Console.WriteLine("Belum ada orang di rumah sakit.");
                return;
            }

            Console.WriteLine($"Jumlah orang di rumah sakit: {daftarOrang.Count}");

            int nomor = 1;
            foreach (Orang orang in daftarOrang)
            {
                Console.Write($"{nomor}. ");
                orang.InfoOrang();
                nomor++;
            }
        }

        // ini saya sediakan method buat manggil Aktivitas() dan hasilnya ntar beda tiap object
        public void JalankanSemuaAktivitas()
        {
            foreach (Orang orang in daftarOrang)
            {
                orang.Aktivitas();
            }
        }
    }
}