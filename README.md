# Azure Function Proxies

## Blob post - [Azure Functions Proxies in Action](https://wp.me/p3mRWu-1wp)

* Learn how to modify requests and responses
* Use a unified endpoint for your microservice architecture
* Mock your API responses during development
* Quickly switch between versions of your APIs
* Development environment setup
* Production proxy and application settings configuration

## Installation instructions
 
1. Install [.NET Core 2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2)
2. Install [Azure Functions Core Tools V2](https://www.npmjs.com/package/azure-functions-core-tools)
    * `npm i -g azure-functions-core-tools --unsafe-perm true`
3. Set the *Debug* properties of `Catalog.API`:
    * **Launch**: Executable
    * **Executable**: dotnet.exe
    * **Application arguments**: %userprofile%\AppData\Roaming\npm\node_modules\azure-functions-core-tools\bin\func.dll host start –pause-on-error –port 1072
4. Set the *Debug* properties of `Backet.API`:
    * **Launch**: Executable
    * **Executable**: dotnet.exe
    * **Application arguments**: %userprofile%\AppData\Roaming\npm\node_modules\azure-functions-core-tools\bin\func.dll host start –pause-on-error –port 1073
5. Set the *Debug* properties of `Ordering.API`:
    * **Launch**: Executable
    * **Executable**: dotnet.exe
    * **Application arguments**: %userprofile%\AppData\Roaming\npm\node_modules\azure-functions-core-tools\bin\func.dll host start –pause-on-error –port 1074


> In case `azure-functions-core-tools` package has installed in different folder, make you need to update application arguments accordingly
