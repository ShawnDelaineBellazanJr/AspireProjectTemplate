# 🚀 ProjectName - .NET Aspire Project Template

This is a **ready-to-use .NET Aspire template** for building **microservices, APIs, and Blazor WebAssembly applications**.  
It supports **dynamic project name replacement**, making it fully adaptable when using `dotnet new`.

## 🎯 Features
✅ **Microservices-ready** with API, App Host, and Web UI  
✅ **Blazor WebAssembly support**  
✅ **Automatic project renaming** (`ProjectName` → Your Project Name)  
✅ **Runs `dotnet restore` automatically** after generation  
✅ **Easily extendable** for AI and automation  

---

## 📌 Getting Started

### 1️⃣ **Install the Template Locally**
```sh
dotnet new --install .
```

### 2️⃣ **Generate a New Project**
```sh
dotnet new projectname-template -n MyCoolApp
```
This will create a new project named **`MyCoolApp`** with full renaming.

### 3️⃣ **Run the Solution**
```sh
cd MyCoolApp
dotnet restore
dotnet run --project src/MyCoolApp.ApiService
```

---

## 📂 Project Structure
```
ProjectName/
│── .template.config/                    # Template metadata folder
│   ├── template.json                     # Template configuration file
│
│── .github/                              # GitHub Actions and CI/CD automation
│── docs/                                 # Documentation
│── src/                                  # Source code
│   ├── ProjectName.ApiService/           # API Service
│   ├── ProjectName.AppHost/              # App Host
│   ├── ProjectName.ServiceDefaults/      # Shared services
│   ├── ProjectName.Web/                  # Blazor WebAssembly frontend
│
│── tests/                                # Unit and Integration Tests
│── .dockerignore                         # Docker ignore settings
│── .gitattributes                        # Git attributes
│── .gitignore                            # Git ignore settings
│── LICENSE.txt                           # License information
│── README.md                             # Project documentation
│── ProjectName.sln                       # Solution file (dynamically renamed)
```

---

## 🚀 How It Works
1. **Uses `ProjectName` as a placeholder** → Gets replaced dynamically.
2. **Applies renaming rules** → Updates namespaces, file names, and folder names.
3. **Runs `dotnet restore` automatically** after project generation.

---

## 🎯 Ideal For
- **Microservices & API Development**  
- **Blazor WebAssembly Projects**  
- **AI-Powered Applications**  

🔥 _Fork & customize this template to fit your needs!_ 🚀
