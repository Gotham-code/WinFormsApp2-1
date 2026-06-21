# Panduan Menambahkan Kolom Catatan ke Tabel Monitoring

## ✅ Apa yang sudah dilakukan di Kode:

1. **MonitoringModel.cs**:
   - ✅ Query `GetAllMonitoring()` - Tambah SELECT `m.catatan AS "CATATAN"`
   - ✅ Query `InsertMonitoring()` - Tambah INSERT `catatan` parameter
   - ✅ Query `UpdateMonitoring()` - Tambah UPDATE `catatan` parameter

2. **MonitoringController.cs**:
   - ✅ Method `SimpanFromInput()` - Assign `model.Catatan = viewInput.textBox2?.Text`

## ⚠️ Yang masih perlu dilakukan di Database:

Anda perlu menjalankan perintah SQL berikut di database PostgreSQL:

### Opsi 1: Menggunakan pgAdmin

1. Buka **pgAdmin** (atau aplikasi SQL client Anda)
2. Hubungkan ke database Anda
3. Buka **Query Tool**
4. Salin dan jalankan perintah ini:

```sql
ALTER TABLE monitoring 
ADD COLUMN IF NOT EXISTS catatan TEXT DEFAULT '';
```

### Opsi 2: Menggunakan Terminal psql

```bash
psql -U your_username -d your_database_name -c "ALTER TABLE monitoring ADD COLUMN IF NOT EXISTS catatan TEXT DEFAULT '';"
```

### Opsi 3: Jalankan file SQL yang sudah disiapkan

File `SQL_ADD_CATATAN_COLUMN.sql` sudah disiapkan di root project untuk referensi.

## ✅ Verifikasi Kolom Sudah Ditambahkan

Setelah menjalankan perintah ALTER TABLE, jalankan perintah ini untuk verifikasi:

```sql
SELECT column_name, data_type, column_default 
FROM information_schema.columns 
WHERE table_name = 'monitoring' 
ORDER BY ordinal_position;
```

Seharusnya muncul kolom baru `catatan` dengan tipe `text`.

## 🎉 Setelah Kolom Ditambahkan

1. **Rebuild** Visual Studio (Ctrl + Shift + B)
2. **Jalankan aplikasi**
3. Buka **Input Monitoring**
4. **Isi catatan** di textBox2
5. Klik **Simpan**
6. Data catatan sekarang akan tersimpan di database! ✅

## 📋 Struktur Kolom Tabel Monitoring Lengkap

| Kolom | Tipe | Keterangan |
|-------|------|-----------|
| id_monitoring | SERIAL (PK) | Primary Key |
| tanggal | TIMESTAMP | Tanggal monitoring |
| id_tanaman | INTEGER (FK) | Foreign Key ke tabel tanaman |
| kondisi_tanaman | VARCHAR | Sehat/Layu |
| catatan | TEXT | Catatan monitoring (BARU ✅) |
| id_user | INTEGER (FK) | Foreign Key ke tabel users/petugas |

---

**Catatan**: Jika kolom sudah ada, perintah `ALTER TABLE ... ADD COLUMN IF NOT EXISTS` tidak akan menimbulkan error.
