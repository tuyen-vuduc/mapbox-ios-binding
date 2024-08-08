dotnet nuget locals -c all
dotnet pack -c Release -t:Clean,Rebuild mapbox-ios.sln --output $PWD/nugets