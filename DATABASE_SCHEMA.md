# Database Schema untuk Monitoring KopiKakao

## Catatan Penting
Query saat ini hanya menggunakan kolom-kolom dasar yang pasti ada di tabel `monitoring`:
- `id_monitoring` (Primary Key)
- `tanggal` (Date/Timestamp)
- `id_tanaman` (Foreign Key ke tabel tanaman)
- `kondisi_tanaman` (Kondisi: Sehat/Layu)
- `id_user` (Foreign Key ke tabel petugas_monitoring/users)

## Kolom yang TIDAK digunakan saat ini (kemungkinan tidak ada):
- `cuaca` - Tidak ada di tabel
- `catatan` - Tidak ada di tabel  
- `hama` - Tidak ada di tabel
- `tinggi_tanaman` - Tidak ada di tabel

## Untuk menambahkan kolom baru ke database:

Jika Anda ingin menambahkan kolom `catatan`, `cuaca`, dan `hama`, jalankan SQL di database:

```sql
ALTER TABLE monitoring ADD COLUMN catatan TEXT DEFAULT '';
ALTER TABLE monitoring ADD COLUMN cuaca VARCHAR(50) DEFAULT '';
ALTER TABLE monitoring ADD COLUMN hama VARCHAR(50) DEFAULT '';
```

Setelah menambahkan kolom, update file `WinFormsApp2\Models\MonitoringModel.cs` kembali dengan parameter yang sesuai.

## Struktur Form InputMonitoring saat ini:
- ✅ Id Monitoring (textBox1)
- ✅ Kondisi (comboBoxPetugas: Sehat/Layu)
- ✅ Jenis Tanaman (comboBoxTanaman: Kopi/Kakao)
- ✅ Tanggal (dateTimePicker1)
- ✅ Cuaca (comboBox2: Cerah/Hujan) - ditampilkan tapi tidak disimpan
- ✅ Hama (comboBox1: Ulat/Tidak Ada) - ditampilkan tapi tidak disimpan
- ✅ Catatan (textBox2) - ditampilkan tapi tidak disimpan

Ketiga field terakhir hanya ditampilkan untuk UI, namun tidak disimpan ke database sampai kolom tersebut ditambahkan ke tabel `monitoring`.
