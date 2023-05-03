This repository contains a basic Blazor WebAssembly application with GitHub authentication supported by Azure Static Web Apps.

It is used in the following article: [Support Auth0 in Azure Static Web Apps for Blazor WebAssembly Apps](https://auth0.com/blog/support-auth0-in-azure-static-web-apps-for-blazor-wasm/).

## To run the application:

Clone the repo: `git clone -b github-authn https://github.com/auth0-blog/blazor-wasm-azure-swa.git`

To run the *Blazor WebAssembly* application locally:

1. Move to the `blazor-wasm-azure-swa` folder 
3. Type `swa start http://localhost:5170 --run "dotnet run"` in a terminal window.
4. Point your browser to `https://localhost:4280`.

## Requirements:

- [.NET SDK 7.0](https://dotnet.microsoft.com/download/dotnet-core/7.0) installed on your machine
- [Azure SWA CLI](https://azure.github.io/static-web-apps-cli/) to emulate Azure SWA locally
- An [Azure](https://azure.microsoft.com/) account to run the app in the cloud

