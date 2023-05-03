This repository contains a basic Blazor WebAssembly application with Auth0 authentication supported by Azure Static Web Apps.

It is used in the following article: [Support Auth0 in Azure Static Web Apps for Blazor WebAssembly Apps](https://auth0.com/blog/support-auth0-in-azure-static-web-apps-for-blazor-wasm/).

## To run the application:
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fauth0-blog%2Fblazor-wasm-azure-swa.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fauth0-blog%2Fblazor-wasm-azure-swa?ref=badge_shield)


Clone the repo: `git clone https://github.com/auth0-blog/blazor-wasm-azure-swa.git`

To run the *Blazor WebAssembly* application locally:

1. Move to the `blazor-wasm-azure-swa` folder
2. Register the app with Auth0 following [these instructions](https://auth0.com/blog/support-auth0-in-azure-static-web-apps-for-blazor-wasm#Register-your-app-with-Auth0)
3. Configure your app following [these instructions](https://auth0.com/blog/support-auth0-in-azure-static-web-apps-for-blazor-wasm#Register-your-app-with-Auth0#Configure-Auth0-as-your-authentication-provider)
4. Type `swa start http://localhost:5170 --run "dotnet run"` in a terminal window.
5. Point your browser to `https://localhost:4280`.

## Requirements:

- [.NET SDK 7.0](https://dotnet.microsoft.com/download/dotnet-core/7.0) installed on your machine
- [Azure SWA CLI](https://azure.github.io/static-web-apps-cli/) to emulate Azure SWA locally
- An [Azure](https://azure.microsoft.com/) account to run the app in the cloud
- An [Auth0 account](https://auth0.com/signup) to authenticate users in the cloud



## License
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fauth0-blog%2Fblazor-wasm-azure-swa.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Fauth0-blog%2Fblazor-wasm-azure-swa?ref=badge_large)