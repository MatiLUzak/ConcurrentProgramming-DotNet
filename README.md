# ConcurrentProgramming-DotNet

## 📌 Opis projektu

**ConcurrentProgramming-DotNet** to aplikacja napisana w języku **C#** z wykorzystaniem platformy **.NET**, mająca na celu demonstrację technik programowania współbieżnego. Projekt jest podzielony na moduły odpowiedzialne za różne aspekty aplikacji, takie jak dane, logika i testy.

## 🛠 Wymagania

Aby uruchomić projekt, potrzebujesz:

- **Visual Studio 2019** lub nowszy z zainstalowanymi komponentami **.NET Desktop Development**
- **.NET Framework 4.7.2** lub nowszy

## 🚀 Instalacja i uruchomienie

1. **Klonowanie repozytorium:**

   ```bash
   git clone https://github.com/MatiLUzak/ProjektWsp.git
   cd ProjektWsp
   ```

2. **Otworzenie projektu w Visual Studio:**

   - Otwórz plik rozwiązania `ProjektWsp.sln` za pomocą Visual Studio.

3. **Przywrócenie pakietów NuGet:**

   - W Visual Studio przejdź do **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution** i upewnij się, że wszystkie wymagane pakiety są zainstalowane.

4. **Kompilacja i uruchomienie aplikacji:**

   - Naciśnij `F5` lub kliknij przycisk **Start** w Visual Studio, aby skompilować i uruchomić aplikację.

## 📂 Struktura projektu

```
ProjektWsp/
├── Dane/
│   ├── DataModel.cs
│   └── ...
├── DaneTest/
│   ├── DataModelTests.cs
│   └── ...
├── Logika/
│   ├── ConcurrencyLogic.cs
│   └── ...
├── LogikaTest/
│   ├── ConcurrencyLogicTests.cs
│   └── ...
├── ProjektWsp/
│   ├── Program.cs
│   └── ...
├── TestProject2/
│   ├── AdditionalTests.cs
│   └── ...
├── .gitattributes
├── .gitignore
├── ProjektWsp.sln
├── README.md
└── ball_log.json
```

- **Dane/** – zawiera modele danych używane w aplikacji.
- **DaneTest/** – zawiera testy jednostkowe dla modeli danych.
- **Logika/** – zawiera logikę aplikacji związaną z programowaniem współbieżnym.
- **LogikaTest/** – zawiera testy jednostkowe dla logiki aplikacji.
- **ProjektWsp/** – zawiera główny punkt wejścia aplikacji (`Program.cs`).
- **TestProject2/** – zawiera dodatkowe testy dla aplikacji.
- **.gitattributes** – plik konfiguracji Git, określający sposób traktowania plików w repozytorium.
- **.gitignore** – plik określający, które pliki i katalogi mają być ignorowane przez Git.
- **ProjektWsp.sln** – plik rozwiązania Visual Studio.
- **ball_log.json** – plik JSON zawierający logi aplikacji.

## ✍️ Autorzy

- **Mateusz Luzak (ML)** – `{737e6731-4039-424d-9ca2-f6d9040ace86}`

## 📜 Licencja

Ten projekt jest licencjonowany na podstawie licencji MIT. Szczegóły znajdują się w pliku `LICENSE`.
