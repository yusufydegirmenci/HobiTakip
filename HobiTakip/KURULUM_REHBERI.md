# 🛠️ Hobi Takip Uygulaması - Kurulum ve Çalıştırma Rehberi

## 📋 Gereksinimler

- **Windows 10/11**
- **.NET 9.0 SDK** (Visual Studio 2022 ile birlikte gelir)
- **Visual Studio 2022** (Community Edition yeterli)

## 🚀 Kurulum Adımları

### 1. **Proje Dosyalarını Kontrol Edin**
Aşağıdaki dosyaların proje klasöründe olduğundan emin olun:
```
HobiTakip/
├── Models/
│   ├── User.cs
│   ├── Hobby.cs
│   ├── Goal.cs
│   ├── Progress.cs
│   ├── Achievement.cs
│   ├── UserAchievement.cs
│   └── UserSettings.cs
├── Database.cs
├── ThemeManager.cs
├── NotificationManager.cs
├── DataExporter.cs
├── LoginForm.cs & .Designer.cs
├── RegisterForm.cs & .Designer.cs
├── MainForm.cs & .Designer.cs
├── AddHobbyForm.cs & .Designer.cs
├── AddProgressForm.cs & .Designer.cs
├── GoalsForm.cs & .Designer.cs
├── AddGoalForm.cs & .Designer.cs
├── GoalDetailsForm.cs & .Designer.cs
├── ProgressViewForm.cs & .Designer.cs
├── AchievementsForm.cs & .Designer.cs
├── PomodoroTimerForm.cs & .Designer.cs
├── SettingsForm.cs & .Designer.cs
├── ChartForm.cs & .Designer.cs
├── NotificationWindow.Designer.cs
├── Program.cs
└── HobiTakip.csproj
```

### 2. **Visual Studio'da Projeyi Açın**
- Visual Studio 2022'yi açın
- "Open a project or solution" seçin
- `HobiTakip.csproj` dosyasını seçin

### 3. **NuGet Paketlerini Yükleyin**
Proje açıldığında otomatik olarak şu paketler yüklenecek:
- `Microsoft.Data.Sqlite` (8.0.0)
- `System.Data.SQLite.Core` (1.0.118)  
- `System.Windows.Forms.DataVisualization` (1.0.0-prerelease)

Eğer otomatik yüklenmezse:
- Solution Explorer'da projeye sağ tıklayın
- "Manage NuGet Packages" seçin
- Yukarıdaki paketleri manuel olarak yükleyin

### 4. **Projeyi Build Edin**
- **Build** → **Build Solution** (Ctrl+Shift+B)
- Hata olmadığından emin olun

### 5. **Çalıştırın**
- **Debug** → **Start Debugging** (F5)
- Veya **Start Without Debugging** (Ctrl+F5)

## 🎯 İlk Çalıştırma

### 1. **Kullanıcı Kaydı**
- Uygulama açıldığında giriş ekranı gelir
- "YENİ HESAP OLUŞTUR" butonuna tıklayın
- Bilgilerinizi girin ve kaydolun

### 2. **Giriş Yapma**
- Kullanıcı adı ve şifrenizle giriş yapın
- Ana sayfa açılacak

### 3. **İlk Hobi Ekleme**
- "Hobi Ekle" butonuna tıklayın
- İlk hobinizi ekleyin
- İlk rozetinizi kazanın! 🏆

## 📦 Setup Dosyası Oluşturma

### Visual Studio ile Publish:
1. **Solution Explorer**'da projeye sağ tıklayın
2. **Publish** seçin
3. **Folder** seçin
4. Çıktı klasörünü belirleyin
5. **Publish** butonuna tıklayın

### Self-Contained Deployment için:
```xml
<!-- HobiTakip.csproj'ye ekleyin -->
<PropertyGroup>
    <PublishSingleFile>true</PublishSingleFile>
    <SelfContained>true</SelfContained>
    <RuntimeIdentifier>win-x64</RuntimeIdentifier>
</PropertyGroup>
```

## 🔧 Sorun Giderme

### Yaygın Hatalar:

#### **1. "Could not find file hobby.ico"**
- ✅ **Çözüldü:** Proje dosyasından ikon referansı kaldırıldı

#### **2. NuGet Paket Hataları**
- Visual Studio'yu kapatın
- `bin` ve `obj` klasörlerini silin
- Visual Studio'yu açın ve **Restore NuGet Packages** yapın

#### **3. Chart Kontrol Hataları**
- `System.Windows.Forms.DataVisualization` paketinin yüklendiğinden emin olun
- Eğer sorun devam ederse, .NET Framework sürümünü kontrol edin

#### **4. Veritabanı Hataları**
- Uygulama klasöründe `hobitakip.db` dosyası otomatik oluşur
- Eğer izin sorunu varsa, uygulamayı yönetici olarak çalıştırın

#### **5. Tema Hataları**
- Registry okuma sorunları olabilir
- Varsayılan Light tema kullanılacak

## 📁 Dosya Yapısı

### Uygulama Çalıştığında Oluşturulacak:
```
[Uygulama Klasörü]/
├── HobiTakip.exe
├── hobitakip.db          [Veritabanı]
├── Microsoft.Data.Sqlite.dll
├── System.Data.SQLite.dll
└── [Diğer DLL dosyaları]
```

### Veri Yedekleme:
- `hobitakip.db` dosyasını kopyalayarak veri yedekleyebilirsiniz
- "Ayarlar" > "Veri Dışa Aktar" ile JSON formatında yedek alabilirsiniz

## 🌟 İpuçları

### **Performans:**
- İlk açılış biraz yavaş olabilir (veritabanı oluşturuluyor)
- Büyük veri setlerinde grafikler yavaş yüklenebilir

### **Kullanım:**
- Pomodoro timer çalışırken uygulamayı kapatmayın
- Tema değişiklikleri anında uygulanır
- Rozetler otomatik kontrol edilir

### **Güvenlik:**
- Şifreler SHA256 ile şifrelenir
- Veriler lokal olarak saklanır
- İnternet bağlantısı gerekmez

## 🚀 Dağıtım için Hazırlık

### **Setup Paketi Oluşturma:**
1. **Advanced Installer** veya **Inno Setup** kullanabilirsiniz
2. Gerekli dosyalar:
   - Tüm EXE ve DLL dosyaları
   - .NET 9.0 Runtime (eğer self-contained değilse)

### **Taşınabilir Sürüm:**
- Tüm dosyaları bir klasöre kopyalayın
- USB'de veya başka bilgisayarlarda çalışır
- `hobitakip.db` dosyası da taşınır

## ✅ Test Checklist

Uygulamayı test ederken kontrol edin:
- [ ] Kullanıcı kaydı ve girişi çalışıyor
- [ ] Hobi ekleme/düzenleme çalışıyor
- [ ] İlerleme kaydetme çalışıyor
- [ ] Hedef oluşturma çalışıyor
- [ ] Grafikler gösteriliyor
- [ ] Rozetler kazanılıyor
- [ ] Pomodoro timer çalışıyor
- [ ] Tema değişimi çalışıyor
- [ ] Bildirimler çalışıyor
- [ ] Veri dışa aktarma çalışıyor

## 🎉 Başarılı Kurulum!

Artık Hobi Takip uygulamanız çalışmaya hazır! 

Yeni özellikler:
- 📊 **Grafikler**
- 🏆 **Rozetler** 
- 🍅 **Pomodoro Timer**
- 🌙 **Dark/Light Tema**
- 📱 **Akıllı Hatırlatıcılar**

**İyi eğlenceler! 🚀**