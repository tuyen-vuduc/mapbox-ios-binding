dotnet nuget locals -c all
msbuild -t:Restore,Rebuild,Pack -p:Configuration=Release,PackageOutputPath=$PWD/nugets