$tag = & git describe --tags --abbrev=8
rm  ./nupkg -force -recurse
dotnet pack /p:PackageVersion=$tag /p:Configuration=Release