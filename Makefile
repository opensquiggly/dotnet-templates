
install-nuget: build
	dotnet new update
	dotnet new install --force OpenSquiggly.Templates

uninstall-nuget:
	dotnet new uninstall OpenSquiggly.Templates

install-local: build
	dotnet new install --force ./templates/monolith+sveltekit

uninstall-local:
	dotnet new uninstall ./templates/monolith+sveltekit

build:
	dotnet build

install-mymonolith1:
	rm -rf ~/dev/dotnet-templates-test/MyMonolith1
	dotnet new opensquiggly-monolith+sveltekit -n MyMonolith1 -o ~/dev/dotnet-templates-test/MyMonolith1

run-mymonolith1:
	dotnet run --project ~/dev/dotnet-templates-test/MyMonolith1/src/App.Web/App.Web.csproj

