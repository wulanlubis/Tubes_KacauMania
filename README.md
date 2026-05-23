# Tubes_KacauMania
> Tugas Besar IF25-21013 Strategi Algoritma — Semester Genap 2026/2027
> **Pemanfaatan Algoritma Greedy dalam pembuatan bot permainan Robocode Tank Royale**

---

## Author

| Nama | NIM |
|------|-----|
| Sena Permatasari | 124140018 |
| Wulandari Lubis | 124140066 |
| Sere Sri Rezeki Sinaga | 124140150 |

---

## Deskripsi Bot

### Main Bot — Gacor
**Strategi: Distance-Based Adaptive Firepower**  
Memilih daya tembak secara greedy berdasarkan jarak ke musuh:
- Jarak < 150 piksel → `Fire(3)` — peluru berat, damage maksimal
- 150 ≤ Jarak < 300 piksel → `Fire(2)` — keseimbangan damage & kecepatan
- Jarak ≥ 300 piksel → `Fire(1)` — peluru ringan, cepat, lebih mudah mengenai target jauh

Gerakan utama membentuk pola melingkar (maju 50 unit + belok kanan 20°) dengan radar sweep 360° setiap siklus.

### Alternative Bot 1 — Syududu
**Strategi: Energy-Aware Adaptive Strategy**  
Menyesuaikan strategi secara dinamis berdasarkan kondisi energi:
- Energi > 50 → Mode Agresif: maju 120 unit, tembak berdasarkan jarak
- Energi ≤ 50 → Mode Defensif: mundur 80 unit, belok 60°, hindari musuh

### Alternative Bot 2 — Kaciw
**Strategi: Survival-First Evasion**  
Memprioritaskan kelangsungan hidup dengan menghindar secara reaktif:
- Selalu tembak `Fire(1)` untuk hemat energi
- Saat kena peluru → langsung kabur ke arah acak (TurnRight 90–180° + Forward 120)
- Gerakan default acak agar lintasan tidak dapat diprediksi musuh

### Alternative Bot 3 — Kacau
**Strategi: Always-Aggressive Maximum Damage**  
Selalu tembak dengan daya tembak maksimal tanpa mempertimbangkan kondisi apapun:
- Setiap musuh terdeteksi → `Fire(3)` langsung
- Saat bertabrakan dengan bot lain → `Fire(3)` + maju 50 unit untuk memaksimalkan Ram Damage

---

## Requirement

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) versi 10.0
- Game engine Robocode Tank Royale (versi modifikasi asisten — tubes1-if2211-starter-pack)
- OS: Windows

---

## Cara Build & Menjalankan Bot

### 1. Clone repository
```bash
git clone https://github.com/wulanlubis/Tubes_KacauMania.git
cd Tubes_KacauMania
```

### 2. Jalankan game engine terlebih dahulu
Pastikan game engine sudah berjalan sebelum menjalankan bot.

### 3. Build & jalankan Main Bot (Gacor)
```bash
cd src/main-bot/Gacor
dotnet build
dotnet run
```

### 4. Build & jalankan Alternative Bots
```bash
# Bot Syududu
cd src/alternative-bots/Syududu
dotnet build
dotnet run

# Bot Kaciw
cd src/alternative-bots/Kaciw
dotnet build
dotnet run

# Bot Kacau
cd src/alternative-bots/Kacau
dotnet build
dotnet run
```

---

## Struktur Repository

```
Tubes_KacauMania/
├── src/
│   ├── main-bot/
│   │   └── Gacor/
│   └── alternative-bots/
│       ├── Syududu/
│       ├── Kaciw/
│       └── Kacau/
├── doc/
│   └── KacauMania.pdf
└── README.md
```

---

## Tautan

- 📄 [Laporan](doc/KacauMania.pdf)
- 🎥 Video YouTube: https://youtu.be/iAU6WSKW0zE
