# Cake Issue for addins that use nullable reference types

This repository reproduces an issue in [Cake](https://github.com/cake-build/cake) that ocurrs, when an addin enables nullable referency types.

If a nullable annotation is used in an Cake alias, that is imported into a Cake script, running the script fails with an error like 

```txt
(3423,57): error CS0234: The type or namespace name 'NullableAttribute' does not exist in the namespace 'System.Runtime.CompilerServices' (are you missing an assembly reference?)
(3423,57): error CS0234: The type or namespace name 'Nullable' does not exist in the namespace 'System.Runtime.CompilerServices' (are you missing an assembly reference?)
```

## Run the repro

Build the sample addin by running

```sh
dotnet build --configuration Debug "ExampleAddin/ExampleAddin.csproj"
```

Run the Cake script that uses the alias


```sh
cd "CakeScript"
dotnet tool restore 
dotnet cake
```
