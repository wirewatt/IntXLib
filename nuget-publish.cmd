@cd IntXLib
..\.nuget\nuget.exe pack IntXLib.csproj -Version 1.0.0.2 -Prop Configuration=Release -OutputDirectory bin
..\.nuget\nuget.exe push bin\IntX.1.0.0.2.nupkg -ApiKey
@pause
