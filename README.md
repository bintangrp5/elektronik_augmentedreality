# 📱 Elektronik Augmented Reality

![Unity](https://img.shields.io/badge/Unity-2021%2B-black?logo=unity)
![C#](https://img.shields.io/badge/C%23-Programming-purple?logo=csharp)
![Platform](https://img.shields.io/badge/Platform-Android-green)
![AR](https://img.shields.io/badge/AR-Vuforia-orange)

---

## 🧩 Overview

**Elektronik Augmented Reality** adalah aplikasi Android berbasis Augmented Reality (AR) yang dikembangkan menggunakan **Unity** dan **Vuforia Engine**.

Aplikasi ini dirancang untuk membantu pengenalan perangkat elektronik secara interaktif menggunakan teknologi **marker-based tracking**, di mana pengguna dapat memindai marker untuk memunculkan objek 3D di dunia nyata.

Pengguna juga dapat berinteraksi langsung dengan objek 3D untuk melihat informasi detail dari setiap perangkat elektronik.

---

## 🎯 Objectives

- Menerapkan teknologi Augmented Reality dalam edukasi.
- Menampilkan objek 3D berbasis marker tracking.
- Memberikan pengalaman interaktif kepada pengguna.
- Mengintegrasikan UI informasi dengan objek 3D.

---

## ✨ Features

- 🎯 **Marker-Based Tracking** menggunakan Vuforia Engine.
- 🧊 **3D Object Visualization** perangkat elektronik.
- 🔄 **Interactive Rotation** objek 3D.
- 👆 **Tap Interaction** untuk menampilkan informasi.
- 📄 **Information Panel UI** untuk detail perangkat.
- 📱 **Android Mobile Support**.

---

## 🛠️ Technologies Used

- Unity Engine (C#)
- Vuforia Engine (AR SDK)
- Android Build Platform

---

## 📱 How It Works

1. User membuka aplikasi di perangkat Android.
2. Kamera mendeteksi *image marker* (target).
3. Sistem Vuforia mengenali *marker*.
4. Objek 3D perangkat elektronik muncul di atas *marker*.
5. User dapat:
   - Memutar objek 3D.
   - Menekan objek untuk membuka panel informasi.

---

## 🧠 Core System

### 🔍 Marker Detection
Menggunakan Vuforia Engine untuk mendeteksi *image target* secara real-time melalui kamera.

### 🧊 3D Rendering
Objek 3D ditampilkan di atas *marker* dengan posisi dan rotasi yang sesuai di dunia nyata.

### 👆 Interaction System
Interaksi pengguna (*user interaction*) menggunakan *touch input* pada layar ponsel untuk memunculkan UI informasi.

---

## 🖼️ Preview

> Tambahkan screenshot atau GIF aplikasi Anda di bawah ini:

![Preview](assets/preview.gif)

---

## 📂 Project Structure

```text
Elektronik Augmented Reality/
│
├── Assets/             
├── Packages/           
├── ProjectSettings/    
├── QCAR/              
├── UserSettings/      
└── README.md


## 🚀 Getting Started

### 📌 Requirements
- Unity 2021+ (Direkomendasikan)
- Android Build Support module terinstal via Unity Hub
- Vuforia Engine package telah diaktifkan
- Perangkat Android untuk testing

### ⚙️ Installation

1. Clone repositori ini ke penyimpanan lokal Anda:
```bash
   git clone [https://github.com/username/elektronik-ar.git](https://github.com/username/elektronik-ar.git)
   ```
2. Buka **Unity Hub**.
3. Klik **Add** dan pilih folder proyek ini.
4. Pastikan **Vuforia Engine** sudah aktif pada pengaturan proyek.
5. Ubah target platform ke **Android** (*Switch Platform*).
6. Lakukan *Build and Run* langsung ke perangkat Android Anda.

---

## 🎮 Controls

| Action | Result |
| :--- | :--- |
| **Scan marker** | Memunculkan objek 3D perangkat |
| **Tap object** | Menampilkan panel informasi detail |
| **Drag / Swipe** | Memutar (*rotate*) model 3D (Opsional) |

---

## 🎯 Learning Outcomes

Proyek ini membantu dalam memahami:
- Implementasi Augmented Reality (AR) dasar pada mobile device.
- Sistem *marker-based tracking* menggunakan Vuforia SDK.
- *3D object rendering* dan penataan tata letak objek di Unity.
- *User interaction* (Raycasting / Touch input) dalam lingkungan AR.
- Proses *deployment* dan *build architecture* aplikasi Android menggunakan Unity.

---

## 🧑‍💻 Developer

**Bintang Rafli Priatama**  
🎮 Unity Developer | AR & Game Development Student

---

## 📌 Future Improvements

- 🎥 Animasi khusus yang interaktif pada setiap objek perangkat.
- 🔊 Fitur penjelasan menggunakan audio (*voice over*).
- 📦 Dukungan *multi-marker* secara simultan dalam satu *frame*.
- 🎨 Peningkatan performa dan estetika UI/UX.
- ☁️ Sistem marker berbasis cloud (*Cloud-based marker system*).

---

## 📄 License

This project is developed for educational purposes.
