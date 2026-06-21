# 📋 PANDUAN MANUAL: Menambahkan Kolom Catatan ke Database

## Database Connection Info (Dari File Anda):
```
Host: localhost
Port: 5432
Username: postgres
Database: dbPuslitFinish
```

---

## ✅ Cara PALING MUDAH: Menggunakan pgAdmin GUI

### Langkah 1: Buka pgAdmin
- Buka browser atau aplikasi pgAdmin
- Atau cari di Start Menu → PostgreSQL → pgAdmin

### Langkah 2: Login & Pilih Database
1. Expand **Servers** → **PostgreSQL**
2. Masukkan password: `Salimbaikhati#33` (jika diminta)
3. Pilih database: **dbPuslitFinish**

### Langkah 3: Buka Query Tool
1. Klik kanan pada **dbPuslitFinish** → **Query Tool**
   ATAU
2. Menu atas → **Tools** → **Query Tool**

### Langkah 4: Copy-Paste dan Jalankan Query

**Salin perintah ini ke Query Tool:**
```sql
ALTER TABLE monitoring ADD COLUMN IF NOT EXISTS catatan TEXT DEFAULT '';
```

**Tekan Ctrl + Enter atau klik tombol ▶️ Execute**

### Langkah 5: Verifikasi Berhasil

Salin perintah ini:
```sql
SELECT column_name, data_type, column_default 
FROM information_schema.columns 
WHERE table_name = 'monitoring' 
ORDER BY ordinal_position;
```

Tekan Ctrl + Enter. Seharusnya muncul baris baru dengan `catatan | text`.

✅ **SELESAI!** Kolom catatan sudah ditambahkan.

---

## 🔧 Alternatif: Command Line (PowerShell)

Jika pgAdmin tidak tersedia:

### Langkah 1: Cari psql.exe

Buka PowerShell dan cari:
```powershell
$pgPath = Get-Command psql.exe -ErrorAction SilentlyContinue | Select-Object -ExpandProperty Source
if ($pgPath) { Write-Host "Found: $pgPath" } else { Write-Host "psql.exe tidak ditemukan" }
```

Jika tidak ditemukan, cek instalasi PostgreSQL di:
- `C:\Program Files\PostgreSQL\*\bin\psql.exe`
- `C:\Program Files (x86)\PostgreSQL\*\bin\psql.exe`

### Langkah 2: Jalankan ALTER TABLE

Ganti `C:\Program Files\PostgreSQL\15\bin\psql.exe` dengan path yang benar:

```powershell
$env:PGPASSWORD = "Salimbaikhati#33"
& "C:\Program Files\PostgreSQL\15\bin\psql.exe" -U postgres -d dbPuslitFinish -h localhost -c "ALTER TABLE monitoring ADD COLUMN IF NOT EXISTS catatan TEXT DEFAULT '';"
$env:PGPASSWORD = ""
```

---

## ✅ Setelah Kolom Ditambahkan

1. **Kembali ke Visual Studio**
2. **Rebuild Solution** (Ctrl + Shift + B)
3. **Jalankan Aplikasi** (F5)
4. **Buka Input Monitoring**
5. **Isi semua data termasuk Catatan**
6. **Klik Simpan**
7. **Cek database** - Data catatan sudah tersimpan! 🎉

---

## ⚠️ Troubleshooting

### Error: "Column already exists"
→ Kolom sudah ada. Lanjut ke step "Setelah Kolom Ditambahkan"

### Error: "Relation monitoring does not exist"
→ Cek nama tabel. Mungkin nama tabel berbeda atau database salah.

### Error: "Permission denied"
→ User postgres mungkin tidak punya akses. Coba dengan:
```sql
GRANT ALL PRIVILEGES ON TABLE monitoring TO postgres;
```

### Error: "Password authentication failed"
→ Password salah. Cek di DatabaseConfig.cs apakah password sesuai.

---

## 📞 Butuh Bantuan?

Jika ada error saat menjalankan, **kirimkan screenshot error message** agar bisa dibantu lebih spesifik.

