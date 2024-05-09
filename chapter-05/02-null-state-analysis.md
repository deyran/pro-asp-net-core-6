# Understanding Null State Analysis

ASP.NET Core projects templates anable *Null State Analysis* for the purpose of alerting the editor and compiler to attempts to access references that may be unintentionally null, preventing null reference exceptions at runtime.

## Nullable and Non-nullable variables

1. C# variable are categorized into two groups: nullabel and non-nullable
2. Nullable variable can hold a null value, while non-nullable variables cannot
3. Developers need to be aware of null references when working with nullable variables

## Denoting Nullable types

1. The term "denoting" refers to explicitly specifying whether a type allows **null** values or not
2. To denote a nullable type, a question mark (**?**), is appended to the type
3. For example, if a variable's type is **string?**, it can be assigned **null** values.
4. When a variable's type is simply **string**, it means that the variable cannot hold a **null** value