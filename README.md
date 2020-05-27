## Project & item templates
This is a collection of custom templates for VB.NET projects and items, mostly intended to fill in the gaps where the official templates don't provide this important support.

Most project templates here provide both .NET Core and .NET Framework editions. The .NET Core editions are installed using `dotnet new`, and the .NET Framework editions are installed using a .VSIX file that you'll generate by building the deployment project for the template. (The deployment project for each is generally named `Installer`.)

### Project templates
---
### `AzureFunctions`
#### *`.NET Core`*
To install:

1. Clone this repository to a location on your local system (e.g. `D:\Templates`)
2. Open a command prompt and navigate to that location
3. Issue the `dotnet new` command to install the template:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`dotnet new -i D:\Templates\Projects\AzureFunctions\HttpTrigger\Project`

To use:

1. Open a command prompt
2. Create and navigate to a subfolder for this project (e.g. `D:\Projects\AzureHttpTrigger`)
3. Issue the `dotnet new` command to create a new project:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`dotnet new azure-http-trigger`



## Item templates
No items yet. Keep checking back.
