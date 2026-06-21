# Analisis 4 Pilar OOP dalam Program WinFormsApp2

## 📌 PENGANTAR
Program ini mengimplementasikan 4 pilar Object-Oriented Programming (OOP):
1. **Encapsulation** (Enkapsulasi)
2. **Inheritance** (Pewarisan)
3. **Polymorphism** (Polimorfisme)
4. **Abstraction** (Abstraksi)

---

## 1️⃣ INHERITANCE (Pewarisan)

### Pengertian
Inheritance memungkinkan class yang satu mewarisi property dan method dari class lainnya.

### Contoh di Program Anda:

#### ✅ File: `View/MenuUtamaAdmin.cs` (Line 13-14)
```csharp
public partial class MenuUtamaAdmin : Form
{
    // MenuUtamaAdmin MEWARISI dari class Form (WinForms)
    // Ini berarti MenuUtamaAdmin mendapatkan semua property dan method dari Form
    // Seperti: Show(), Hide(), Location, Size, BackColor, dll
```

**Penjelasan:**
- `MenuUtamaAdmin` **mewarisi** (`inherit`) dari `Form`
- `:` tanda colon menunjukkan relationship inheritance
- Dengan mewarisi, MenuUtamaAdmin otomatis memiliki property Form seperti `ClientSize`, `BackgroundImage`, `DoubleBuffered`

#### ✅ File: `View/DashboardAdmin.cs` (Line ?)
```csharp
public partial class DashboardAdmin : Form
{
    // Sama seperti MenuUtamaAdmin, DashboardAdmin mewarisi dari Form
}
```

#### ✅ File: `View/Tanaman.cs`
```csharp
public partial class Tanaman : Form
{
    // Form untuk CRUD Tanaman
    // Mewarisi dari Form -> mendapatkan semua fungsi window
}
```

#### ✅ File: `View/Lahan.cs`
```csharp
public partial class Lahan : Form
{
    // Form untuk CRUD Lahan
    // Mewarisi dari Form
}
```

---

## 2️⃣ ENCAPSULATION (Enkapsulasi)

### Pengertian
Enkapsulasi adalah proses menyembunyikan detail internal class dan hanya menampilkan interface yang diperlukan melalui access modifier (public, private, protected).

### Contoh di Program Anda:

#### ✅ File: `Models/TanamanModel.cs`
```csharp
public class TanamanModel
{
    // PUBLIC PROPERTIES - Bisa diakses dari mana saja
    public int IdTanaman { get; set; }
    public int IdLahan { get; set; }
    public string NamaTanaman { get; set; }
    public int JumlahPohon { get; set; }

    // PRIVATE METHOD - Hanya bisa diakses dalam class ini
    private bool ValidasiTanaman()
    {
        // Logic validasi yang bersifat internal
    }
}
```

**Penjelasan:**
- `public` property bisa diakses dari View atau Controller
- `private` method hanya digunakan untuk proses internal
- Ini melindungi data agar tidak diakses/diubah sembarangan

#### ✅ File: `UserController/TanamanController.cs`
```csharp
public class TanamanController
{
    // PRIVATE DatabaseConfig - Hanya digunakan internal
    private DatabaseConfig db = new DatabaseConfig();

    // PUBLIC METHOD - Bisa dipanggil dari View
    public DataTable GetAllTanaman()
    {
        return db.ExecuteQuery("SELECT * FROM tanaman");
    }

    // PRIVATE METHOD - Helper internal
    private bool ValidateInput(TanamanModel model)
    {
        // Logika validasi internal
    }
}
```

**Penjelasan:**
- `db` adalah `private` → hanya Controller yang bisa akses database
- `GetAllTanaman()` adalah `public` → View bisa memanggil untuk ambil data
- Data validation disembunyikan dalam method private

#### ✅ File: `View/MenuUtamaAdmin.cs` (Line 15-16)
```csharp
public partial class MenuUtamaAdmin : Form
{
    // PRIVATE database connection - tidak bisa diakses dari luar
    private DatabaseConfig db = new DatabaseConfig();

    // PUBLIC METHOD - bisa dipanggil dari form lain
    public MenuUtamaAdmin()
    {
        InitializeComponent();
    }

    // PRIVATE METHOD - hanya untuk internal class
    private void LoadDashboardData()
    {
        // ...
    }

    // PRIVATE METHOD - protected dari akses luar
    private int GetTotalTanaman()
    {
        // ...
    }
}
```

---

## 3️⃣ ABSTRACTION (Abstraksi)

### Pengertian
Abstraction menyembunyikan kompleksitas dan hanya menampilkan fungsi yang penting.

### Contoh di Program Anda:

#### ✅ File: `Data/DatabaseConfig.cs`
```csharp
public class DatabaseConfig
{
    // ABSTRAKSI: User hanya perlu tahu ada method ExecuteQuery
    // Mereka TIDAK perlu tahu detail koneksi, SQL execution, error handling

    public DataTable ExecuteQuery(string query)
    {
        // Semua proses kompleks database tersembunyi di sini
        // - Buka koneksi
        // - Jalankan query
        // - Ambil hasil
        // - Tutup koneksi
        // - Handle error

        // User cukup panggil method ini saja
    }

    public void ExecuteNonQuery(string query)
    {
        // Abstraksi untuk INSERT, UPDATE, DELETE
    }
}
```

**Penjelasan:**
- User (Controller/View) hanya perlu tahu ada method `ExecuteQuery()`
- Mereka tidak perlu tahu detail koneksi database, SQL parsing, dll
- Kompleksitas database tersembunyi di dalam class ini

#### ✅ File: `UserController/TanamanController.cs` (Abstraksi Operasi CRUD)
```csharp
public class TanamanController
{
    // User hanya perlu tahu ada 4 method CRUD
    // Tidak perlu tahu detail query SQL dan database logic

    public DataTable GetAllTanaman() // READ
    {
        // Query complexity disembunyi
    }

    public bool InsertTanaman(TanamanModel model) // CREATE
    {
        // SQL INSERT disembunyi
    }

    public bool UpdateTanaman(TanamanModel model) // UPDATE
    {
        // SQL UPDATE disembunyi
    }

    public bool DeleteTanaman(int id) // DELETE
    {
        // SQL DELETE disembunyi
    }
}
```

#### ✅ File: `View/LoginForm.cs` (Abstraksi Authentication)
```csharp
// User (pengguna aplikasi) hanya tahu:
// - Input username & password
// - Klik Login
// - Sistem akan cek ke database

// Mereka TIDAK perlu tahu:
// - Detail query SQL untuk cek user
// - Password hashing/encryption
// - Session management
// - Database connection details

// Semua itu diabstraksi di Controller dan Database Layer
```

---

## 4️⃣ POLYMORPHISM (Polimorfisme)

### Pengertian
Polymorphism memungkinkan object yang berbeda merespons method yang sama dengan cara berbeda.

### Contoh di Program Anda:

#### ✅ Method Overriding - File: `View/MenuUtamaAdmin.cs` (Line 73-76)
```csharp
public partial class MenuUtamaAdmin : Form
{
    // Method OnLoad di-OVERRIDE dari class Form
    // MenuUtamaAdmin punya implementasi sendiri untuk OnLoad

    protected override void OnLoad(EventArgs e)
    {
        // Implementasi custom MenuUtamaAdmin
        base.OnLoad(e);  // Panggil method parent terlebih dahulu
        LoadDashboardData();
    }
}
```

**Penjelasan:**
- Keyword `override` menunjukkan polymorphism
- Method `OnLoad()` ada di Form (parent class)
- Tapi MenuUtamaAdmin punya implementasi sendiri
- Setiap form bisa punya OnLoad() yang berbeda-beda

#### ✅ File: `View/DashboardAdmin.cs`
```csharp
public partial class DashboardAdmin : Form
{
    // DashboardAdmin juga bisa punya override OnLoad sendiri
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // Implementasi berbeda dengan MenuUtamaAdmin
    }
}
```

#### ✅ File: `View/MenuUtamaPetugas.cs`
```csharp
public partial class MenuUtamaPetugas : Form
{
    // Sama dengan MenuUtamaAdmin
    // Tapi implementasi OnLoad bisa berbeda
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // UI dan data berbeda dengan MenuUtamaAdmin
    }
}
```

**Contoh Polymorphism:**
```csharp
// Semua class di bawah mewarisi Form dan bisa override method Form
Form form1 = new MenuUtamaAdmin();     // Polymorphic reference
Form form2 = new DashboardAdmin();     // Bisa di-reference sebagai Form
Form form3 = new MenuUtamaPetugas();   // Tapi behavior beda-beda

form1.Show();  // Jalankan Show() yang sama, tapi hasil beda
form2.Show();  
form3.Show();
```

---

## 📊 RINGKASAN IMPLEMENTASI 4 PILAR OOP

| Pilar | Contoh di Program | Baris/File |
|-------|-------------------|-----------|
| **Inheritance** | `class MenuUtamaAdmin : Form` | View/MenuUtamaAdmin.cs:13 |
| **Inheritance** | `class DashboardAdmin : Form` | View/DashboardAdmin.cs |
| **Inheritance** | `class Tanaman : Form` | View/Tanaman.cs |
| **Encapsulation** | `private DatabaseConfig db;` | UserController/TanamanController.cs |
| **Encapsulation** | `public DataTable GetAllTanaman()` | UserController/TanamanController.cs |
| **Encapsulation** | `public string NamaTanaman { get; set; }` | Models/TanamanModel.cs |
| **Abstraction** | `public DataTable ExecuteQuery()` | Data/DatabaseConfig.cs |
| **Abstraction** | Controller menyembunyikan SQL logic | UserController/* |
| **Polymorphism** | `protected override void OnLoad()` | View/MenuUtamaAdmin.cs:73 |
| **Polymorphism** | Setiap Form override OnLoad berbeda | Multiple View files |

---

## 🎯 KESIMPULAN

Program WinFormsApp2 Anda sudah menerapkan semua 4 pilar OOP:

1. **INHERITANCE**: Semua View mewarisi dari `Form`
2. **ENCAPSULATION**: Menggunakan access modifier (private, public) untuk proteksi data
3. **ABSTRACTION**: Database logic disembunyikan di DatabaseConfig dan Controller
4. **POLYMORPHISM**: Override method Form seperti OnLoad() dengan implementasi custom

Struktur ini mengikuti best practice dengan memisahkan:
- **Model** (Data)
- **Controller** (Business Logic)
- **View** (UI)
- **Data** (Database Connection)

Ini adalah arsitektur MVC yang baik! ✅
