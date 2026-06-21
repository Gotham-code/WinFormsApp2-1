-- SQL Script untuk PostgreSQL
-- Tambahkan kolom catatan ke tabel monitoring

-- Syntax PostgreSQL (BENAR untuk database Anda):
ALTER TABLE monitoring ADD COLUMN IF NOT EXISTS catatan TEXT DEFAULT '';

-- Jika query di atas tidak berfungsi, gunakan syntax alternatif:
-- ALTER TABLE monitoring ADD COLUMN catatan TEXT;
-- ALTER TABLE monitoring ALTER COLUMN catatan SET DEFAULT '';

-- Verifikasi kolom sudah ditambahkan:
SELECT column_name, data_type FROM information_schema.columns 
WHERE table_name = 'monitoring' ORDER BY ordinal_position;
