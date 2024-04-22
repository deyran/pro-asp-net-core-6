# Essencial C# features

## Preparing for this chapter

**Listing 5-1**. Creating the Example Project

```
dotnet new web --no-https --output LanguageFeatures
dotnet new sln -o LanguageFeatures
dotnet sln LanguageFeatures add LanguageFeatures
```

1. **dotnet new web --no-https --output LanguageFeatures**

* Creates a new ASP.NET Core web application project
* Disables HTTPS for the project
* Sets the output directory to **LanguageFeatures**

2. **dotnet new sln -o LanguageFeatures:**

* Creates a new solution file (**.sln**) in the directory **LanguageFeatures**
* Solution files are used to manage multiple projects as a single unit

3. **dotnet sln LanguageFeatures add LanguageFeatures**

* Adds the **LanguageFeatures project** (.csproj file) to the existing solution file **LanguageFeature.sln**
* Associate the project with the solution, allowing you to build, managem and reference it within the solution