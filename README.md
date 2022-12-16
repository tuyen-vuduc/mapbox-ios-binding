# Mapbox for Xamarin.iOS
A Xamarin.iOS binding library for [Mapbox](https://www.mapbox.com/ios-sdk/) library.

## About
This project is maintained by [tuyen-vuduc](https://github.com/tuyen-vuduc).<br> 
At the momment, I don't have free time to contribute to the project, but if there is a paid request, I am happy to talk to.

## Installation

```
Install-Package MapboxMapObjC.iOS
```

## Usage

- 1/ How to use: Please follow the official guide [here](https://www.mapbox.com/ios-sdk/).
- 2/ Create `Mapbox.iOSQs.props` file from `Mapbox.iOSQs.props.template`
- 3/ Replace `YOUR_MAPBOX_DOWNLOADS_TOKEN` with your real token from Mapbox
```
<MAPBOX_DOWNLOADS_TOKEN>YOUR_MAPBOX_DOWNLOADS_TOKEN</MAPBOX_DOWNLOADS_TOKEN>
```

- 3/ Replace [your Mapbox access token](https://account.mapbox.com/) in `ViewController.cs`
```
var myResourceOptions = new MBMResourceOptions(
                "YOUR_MAPBOX_TOKEN", // TODO Put your token here
                null, null, null, null);
```

## How to upgrade
It takes time to do the binding library and/or upgrade it. Microsoft intends to make it a lot simpler in the future, but not now.

Here are steps if you want to make changes and/or upgrade to the libraries

- 1/ Download latest artifacts from Mapbox as per its installation guide
- 2/ Run `chmod +x ./gen.sh`
- 3/ Run `./gen.sh`
- 4/ Compile and correct any errors shown up
- 5/ Update `AssemblyInfo.cs` files with the right version number
- 6/ Update `*.nuspec` files to have the right version number
- 7/ Run `sh build.sh` to create nuget packages
- 8/ Commit and create a PR

## IMPROTANT
Mapbox SDK for iOS now is written in Swift and not very compatible with Objective-C, hence it won't be that friendly when doing the binding.
I have to create an additional framework to make the bridge between Swift & C# in Objective-C, it's really a time consuming task. 
It'll require support from the developers like you in the community.

## Maintainer
This project is maintained by [tuyen-vuduc](https://github.com/tuyen-vuduc) in his spare time and/or when requested.<br>

If you find this project is helpful, please give it a star, become a sponsor of the project and/or buy him a coffee.

[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/tuyen.vuduc)

## License

Mapbox binding library for iOS itself is released under the MIT license.
See [LICENSE](./LICENSE) for details.

This license doesn't override and/or replace [the licence from Mapbox](./artifacts/LICENSE.md).