# Azure Settings Merger for Windows Forms

## Overview
The Azure Settings Merger is a Windows Forms tool built with C# and targeting .NET 8, designed to facilitate local development and testing of .NET applications. It enables developers to merge application settings from Azure resources directly into their local appsettings.json or local.settings.json files. This process simplifies the task of configuring local environments to mirror cloud settings, ensuring that local testing is both accurate and efficient.

## Prerequisites
Before using the Azure Settings Merger, ensure you have the following prerequisites installed and set up on your development machine:

- .NET 8 SDK: Required to run the tool. If not already installed, download and install from the official [.NET download page](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks).
- Azure CLI: The tool uses Azure CLI for authentication and fetching Azure app settings. If you haven't installed Azure CLI, follow the instructions on the official [Azure CLI installation guide](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli).

## Setup Instructions
1. **Clone or Download the Tool**: Clone this repository or download the source code to your local machine.

```bash
git clone https://github.com/ivanstefanov/SettingsMerger.git
```
2. **Build the Solution**: Open the solution in Visual Studio or use the .NET CLI to build the project.

```bash
dotnet build
```

3. **Run the Tool**: Navigate to the output directory and run the executable.
```bash
dotnet run
```

## Usage
1. **Login to Azure:**

Before using the tool, authenticate with Azure using the Azure CLI. Open a terminal and run:

```bash
az login
```
Follow the on-screen instructions to complete the authentication process.

2. **Obtain Application Settings:** (only if you are planning to merge the setting via export file)

Use the Azure CLI to list the application settings for your Azure web app:
```bash
az webapp config appsettings list -g  "{RESOURCE_GROUP_NAME}" -n  "{RESOURCE_NAME}" -o json > {RESOURCE_NAME}.settings.json
```
Ensure you replace **<RESOURCE_NAME>** and **<RESOURCE_GROUP_NAME>** with your actual app name and resource group.

3. Using the Tool:

- Launch the Azure Settings Merger tool.
- Follow the on-screen instructions to input the necessary information, including the path to your local **appsettings.json** or **local.settings.json** file and the Azure application settings to merge.
- Click the "Merge" button to start the process. The tool will automatically merge the Azure settings into your local configuration file.

## Contribution
1. Request access by posting a comment under the contributor post in the github [discussion tab](https://github.com/ivanstefanov/SettingsMerger/discussions/3)
2. Create a feature branch.
3. Do your changes.
4. Push your branch.
5. Create pull request with well described reasoning about the changes.
6. Wait for approval.
7. Merge your changes after the approval.

## Further development
The purpose of this tool is to become more and more useful for the developers who works with Azure by adding more and more features that can automate their work and helps them to save precious time.


## Support
If you encounter any issues or have questions regarding the Azure Settings Merger tool, please open an issue in the GitHub repository.
