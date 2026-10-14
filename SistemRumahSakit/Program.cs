using System;

namespace SistemRumahSakit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test objek rumahsakit
            RumahSakit rumahSakit = new RumahSakit();

            // test objek beberapa orang
            Orang pengunjung = new Orang("Andromok", 50);
            Pasien pasien1 = new Pasien("Ababil", 25, "Sakit kaki");
            PasienAnak pasienAnak1 = new PasienAnak("David", 7, "Sakit hati");
            PasienDewasa pasienDewasa1 = new PasienDewasa("Excel", 30, "Demam dan batuk");
            Dokter dokter1 = new Dokter("Wahyudi Dwi", 40, "Penyakit Dalam");
            Perawat perawat1 = new Perawat("Vincent Hansen", 28, "Perawat Umum");

            // test tambahkan objek ke rumah sakit
            Console.WriteLine("Menambahkan Orang ke Rumah Sakit...");
            rumahSakit.TambahOrang(pengunjung);
            rumahSakit.TambahOrang(pasien1);
            rumahSakit.TambahOrang(pasienAnak1);
            rumahSakit.TambahOrang(pasienDewasa1);
            rumahSakit.TambahOrang(dokter1);
            rumahSakit.TambahOrang(perawat1);

            // tampilkaan seluurh data
            Console.WriteLine();
            Console.WriteLine("Daftar Orang di Rumah Sakit:");
            rumahSakit.DaftarOrang();

            // test polimorfisme
            // satu perintah Aktivitas() menghasilkan perilaku berbeda tiap objek
            Console.WriteLine();
            Console.WriteLine("Test Polimorfisme");
            rumahSakit.JalankanSemuaAktivitas();

            // panggil method khusus tiap class tertentu
            Console.WriteLine();
            Console.WriteLine("Method Khusus");
            pasien1.CekKeluhan();
            pasienAnak1.Menangis();
            pasienDewasa1.Konsultasi();
            dokter1.CekSpesialis();
            dokter1.Diagnosa();
            perawat1.CekPasien();

            // disini saya jawab tiap soal

            // Soal 1: Aktivitas() pada objek Dokter dan Pasien
            Console.WriteLine();
            Console.WriteLine("Soal 1: Aktivitas pada objek Dokter dan Pasien:");
            dokter1.Aktivitas();
            pasien1.Aktivitas();

            // Soal 2: Diagnosa() pada objek Dokter
            Console.WriteLine();
            Console.WriteLine("Soal 2: Diagnosa() pada objek Dokter:");
            dokter1.Diagnosa();

            // Soal 3: Informasi lengkap (nama, umur, spesialisasi) objek Dokter
            Console.WriteLine();
            Console.WriteLine("Soal 3: Informasi lengkap (nama, umur, spesialisasi) objek Dokter:");
            dokter1.InfoOrang();     // nama dan umur (dari class Orang)
            dokter1.CekSpesialis();  // spesialisasi (dari class TenagaMedis)

            // Soal 4: Menangis() pada objek PasienAnak
            Console.WriteLine();
            Console.WriteLine("Soal 4: Menangis() pada objek PasienAnak:");
            pasienAnak1.Menangis();

            // Soal 5: Variabel bertipe Orang diisi objek Perawat
            Console.WriteLine();
            Console.WriteLine("Soal 5: Variabel bertipe Orang diisi objek Perawat:");
            Orang orangPerawat = new Perawat("Kholius Majid", 30, "Perawat Anak");
            orangPerawat.Aktivitas();
            // orangPerawat.CekPasien(); -----> langsugn error karena .CekPasien itu milik si Class Perawat, sementara orangPerawat diinisiasi pakai class Orang
        }
    }
}