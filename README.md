<div align="center">

# 📝 QuizApp

### Interactive online quiz and timed assessment management application built with ASP.NET Core and C#

[![.NET](https://img.shields.io/badge/.NET-ASP.NET_Core-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-Language-239120?style=flat-square&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![MVC](https://img.shields.io/badge/Architecture-MVC-blue?style=flat-square)](https://dotnet.microsoft.com/apps/aspnet)
[![License](https://img.shields.io/badge/License-MIT-blue?style=flat-square)](LICENSE)

[Overview](#-overview) •
[Features](#-key-features) •
[Credentials](#-default-administrator-credentials) •
[Tech Stack](#-tech-stack) •
[Quick Start](#-quick-start) •
[License](#-license)

</div>

---

## 📌 Overview

**QuizApp** is a full-featured, interactive **Quiz Management Application** engineered with **ASP.NET Core** and **C#**. It provides instructors and administrators with tools to create, categorize, and schedule dynamic assessments, while giving students a responsive interface for timed tests, instant automated scoring, and performance analytics.

### Key Highlights
- ⏱️ **Dynamic Quiz Engine**: Timed assessments, multiple-choice questions (MCQs), randomized options, and immediate answer review.
- 👨‍🏫 **Instructor & Admin Suite**: Complete management portal for categories, questions, difficulty levels, and scheduled exams.
- 📊 **Instant Automated Scoring**: Live score calculations with detailed breakdowns of correct, incorrect, and skipped responses.
- 🔐 **Role-Based Authentication**: Strict separation of Student and Administrator capabilities.

---

## 🔑 Default Administrator Credentials

For initial local setup and testing:

| Username | Password | Role |
| :--- | :--- | :--- |
| `Admin` | `Password123` | Administrator |

---

## 🛠 Tech Stack

| Domain | Technologies |
| :--- | :--- |
| **Framework & Runtime** | .NET, ASP.NET Core MVC |
| **Language** | C# |
| **Database & ORM** | Entity Framework Core, SQL Server / LocalDB |
| **Frontend & UI** | Razor Views, Bootstrap, HTML5 / CSS3 |
| **Security** | ASP.NET Core Identity with Role-Based Access Control |

---

## 📂 Repository Layout

```text
├── QuizApp.sln              # Visual Studio solution file
├── QuizApp/                 # Main ASP.NET Core Web Application
│   ├── Controllers/         # MVC Controllers (Quiz, Admin, Account)
│   ├── Models/              # Domain entities, ViewModels, and question models
│   ├── Views/               # Razor templates (Quiz taking, admin portal, results)
│   ├── wwwroot/             # Static assets (CSS, JS, vendor libraries)
│   └── appsettings.json     # Configuration and connection strings
└── .github/                 # CI/CD workflow configurations
```

---

## 🚀 Quick Start

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (or Visual Studio 2022+ with ASP.NET workload)

### 1. Clone & Run via .NET CLI
```bash
# Clone the repository
git clone https://github.com/akazad13/quiz-app.git
cd quiz-app

# Restore dependencies & run
dotnet restore
dotnet run --project QuizApp
```
Navigate to `https://localhost:5001` (or the URL displayed in your terminal).

### 2. Running with Visual Studio
1. Open `QuizApp.sln` in Visual Studio.
2. Wait for NuGet packages to restore automatically.
3. Press **F5** or click **Run**.

---

## 👤 Author

**Md. Abul Kalam**
- GitHub: [@akazad13](https://github.com/akazad13)
- LinkedIn: [Md. Abul Kalam](https://linkedin.com/in/akazad13)

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
