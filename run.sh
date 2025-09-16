function build() {
    dotnet build MSALAuthConsole.csproj
}

function run() {
    dotnet run --project MSALAuthConsole.csproj
}