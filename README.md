# 🧠 Interactive Online Quiz Management Application

[![.NET](https://img.shields.io/badge/.NET-C%23-512BD4?style=flat&logo=dotnet)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20App-5C2D91?style=flat&logo=dotnet)](https://dotnet.microsoft.com/apps/aspnet)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

A full-featured, interactive **Quiz Management Application** engineered with **ASP.NET Core** and **C#**. Enables instructors and administrators to create, categorize, and manage dynamic quizzes, while providing students and participants with real-time timed assessments, scoring, and performance analytics.

---

## 🌟 Features

- **🎓 Quiz Engine**: Timed assessments, multiple-choice questions (MCQs), instant score calculation, and answer review.
- **🛠️ Admin & Instructor Portal**: Create, update, and manage categories, questions, options, and quiz schedules.
- **📊 Real-time Scoring & Results**: Immediate feedback with breakdown of correct/incorrect answers upon submission.
- **🔐 Role-Based Access Control**: Secure authentication separating Student and Administrator experiences.

---

## 🔑 Default Administrator Credentials

For initial local setup and testing:

| Username | Password | Role |
| :--- | :--- | :--- |
| Admin | Password123 | Administrator |

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) or Visual Studio 2022+ with ASP.NET and web development workload.

### Running with Visual Studio
1. Open QuizApp.sln in Visual Studio.
2. Wait a few moments for NuGet packages to restore automatically.
3. Press F5 or click **Run** (https/IIS Express).

### Running via .NET CLI
`ash
# Clone the repository
git clone https://github.com/akazad13/quiz-app.git
cd quiz-app

# Restore dependencies & run
dotnet restore
dotnet run --project QuizApp
`

Navigate to https://localhost:5001 (or the URL displayed in the terminal).

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.