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
5. Developers should check that the denoted nullable type isn't null before attempting to access any of the fields

## Ensuring fields and properties are assigned values

Taking the *Product* class and its *Name* field as an example, this field is a non-nullable (not annotated with a question mark) string type. A consequence of using non-nullable types like Name is to be assigned a value when a new instance of the enclosing class is created, and that value would be null. And this is a problem because we cannot assign null to a non-nullable property, even indirectly