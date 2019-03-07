all: dotnet

dotnet: main.cs listForm.cs 
	csc main.cs listForm.cs
