## Project & item templates
This is a collection of custom templates for VB.NET projects and items, mostly intended to fill in the gaps where the official templates don't provide this important support.

Most templates here provide both .NET Core and .NET Framework editions. The .NET Core editions are installed using `dotnet new`, and the .NET Framework editions are installed using a .VSIX file that you'll generate by building the deployment project for the template. (The deployment project for each is generally named `Installer`.)

### Project templates
---
#### `AzureFunctions`
##### *`.NET Core`*
To install:

1. Clone this repository to a folder on your local system (e.g. `D:\Templates`)
2. At a command prompt, `cd` to the project folder (e.g. `D:\Templates\Projects\AzureFunctions\<TriggerType>\Project`)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;...where `<TriggerType>` is the template you want (e.g. `D:\Templates\Projects\AzureFunctions\Http\Project`)

3. Issue the `dotnet new` command to install the template:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`dotnet new -i .\`

4. Alternatively, to install from [NuGet](https://www.nuget.org/packages/Intexx.Templates.AzureFunctions) without cloning, issue this command instead:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`dotnet new -i Intexx.Templates.AzureFunctions`

To use:

1. Open a command prompt
2. Create and `cd` to a subfolder for the new project (e.g. `D:\Projects\AzureFunctionHttp`)
3. Issue the `dotnet new` command to create the project:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`dotnet new azure-function-<TriggerType>`

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;...where `<TriggerType>` is the template you want (e.g. `http`)


### Item templates
---
No templates yet. Keep checking back.
