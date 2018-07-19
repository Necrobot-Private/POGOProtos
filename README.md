POGOProtos [![Build status](https://ci.appveyor.com/api/projects/status/o5j4071rx6on2ere/branch/master?svg=true)](https://ci.appveyor.com/project/jjskuld/pogoprotos/branch/master)
===================

This repository contains the [ProtoBuf](https://github.com/google/protobuf) `.proto` files needed to decode the PokémonGo RPC.

If you want to know which messages are implemented right now, click [here](https://github.com/Furtif/POGOProtos/blob/master/src/POGOProtos/Networking/Requests/RequestType.proto).

# Usage


If you want to figure out the current version in an automated system, use this file.

https://raw.githubusercontent.com/Furtif/POGOProtos/master/.current-version

*Note: This file will contain pre-release versions too.*

## Preparation

Current recommended protoc version: "Protocol Buffers v3.5.1".

You can find download links [here](https://github.com/google/protobuf/releases).

### Windows
Be sure to add `protoc` to your environmental path.

### *nix
Ensure that you have the newest version of `protoc` installed.

### OS X
Use `homebrew` to install `protobuf ` with `brew install --devel protobuf`.

## Compilation
The compilation creates output specifically for the target language, i.e. respecting naming conventions, etc.  
This is an example of how the generated code will be organized:

```
python compile.py cpp:
 - POGOProtos/Data/PlayerData.proto -> POGOProtos/Data/PlayerData.pb.cpp
```
```
python compile.py csharp:
 - POGOProtos/Data/PlayerData.proto -> POGOProtos/Data/PlayerData.g.cs
 ```
 ```
python compile.py go:
 - POGOProtos/Data/*.proto -> github.com/aeonlucid/pogoprotos/data
 - POGOProtos/Data/PlayerData.proto -> github.com/aeonlucid/pogoprotos/data/player_data.pb.go
```
```
python compile.py java:
 - POGOProtos/Data/*.proto -> com/github/aeonlucid/pogoprotos/Data.java
 ```
 ```
python compile.py js:
 - POGOProtos/**/*.proto -> pogoprotos.js
```
```
python compile.py objc:
 - POGOProtos/Data/PlayerData.proto -> POGOProtos/Data/PlayerData.pbobjc.m
```
```
python compile.py python:
 - POGOProtos/Data/*.proto -> pogoprotos/data/__init__.py
 - POGOProtos/Data/PlayerData.proto -> pogoprotos/data/player_data_pb2.py
```
```
python compile.py ruby:
 - POGOProtos/Data/*.proto -> pogoprotos/data.rb
 - POGOProtos/Data/PlayerData.proto -> pogoprotos/data/player_data.rb
```

## Extra information

 - Run ```python compile.py --help``` for help.
 - You can find all available languages here [https://github.com/google/protobuf](https://github.com/google/protobuf).

#### Libraries

If you don't want to compile POGOProtos but instead use it directly, check out the following repository.

| Language              | Source                                                  |
|-----------------------|---------------------------------------------------------|
| NodeJS                | https://github.com/pogosandbox/pogobuf                  |
| NodeJS (pure JS)      | https://github.com/pogosandbox/node-pogo-protos         |
| .NET (nuget pack)     | https://www.nuget.org/packages/POGOProtos.Core          |
| .NET (nuget source)   | https://github.com/Furtif/POGOProtos.Core               |
| .NET (csproj source)  | https://github.com/TheUnnamedOrganisation/POGOProtos    |
| PHP                   | https://github.com/jaspervdm/pogoprotos-php             |
| Go                    | https://github.com/pkmngo-odi/pogo-protos               |
| Haskell               | https://github.com/relrod/pokemon-go-protobuf-types     |
| Rust                  | https://github.com/rockneurotiko/pokemon-go-protobuf-rs |

#### Versioning

We are following [semantic versioning](http://semver.org/) for POGOProtos.  Every version will be mapped to their current PokémonGo version.

| Version      | Android       | iOS           | Extra                     |
|--------------|---------------|---------------|---------------------------|
| 2.29.1       | 0.109.2       | 1.79.2        |                           |
| 2.27.0       | 0.105.0       | 1.75.0        |                           |
| 2.26.0       | 0.101.1       | 1.71.1        |                           |
| 2.25.0       | 0.99.2        | 1.69.2        |                           |
| 2.24.0       | 0.97.2        | 1.67.2        |                           |
| 2.23.1       | 0.95.3        | 1.65.3        | Updated protobuf to 3.5.1 |
| 2.23.0       | 0.95.3        | 1.65.3        |                           |
| 2.22.0       | 0.91.1        | 1.59.1        |                           |
| 2.21.0       | 0.87.5        | 1.57.5        |                           |
| 2.20.0       | 0.85.1        | 1.55.1        |                           |
| 2.19.2       | 0.83.2        | 1.53.2        | Updated protobuf to 3.5.0 |
| 2.19.1       | 0.83.2        | 1.53.2        |                           |
| 2.18.2       | 0.79.4        | 1.49.4        |                           |
| 2.18.1       | 0.79.3        | 1.49.3        |                           |
| 2.18.0       | 0.79.2        | 1.49.2        |                           |
| 2.17.0       | 0.77.1        | 1.47.1        |                           |
| 2.16.0       | 0.75.0        | 1.45.0        |                           |
| 2.15.0       | 0.73.1        | 1.43.1        | Updated protobuf to 3.4.0 |
| 2.14.0       | 0.71.0        | 1.41.0        |                           |
| 2.13.0       | 0.69.1        | 1.39.1        |                           |
| 2.12.0       | 0.69.0        | 1.39.0        |                           |
| 2.11.0       | 0.67.2        | 1.37.2        |                           |
| 2.11.0-beta  | 0.67.1        | 1.37.1        |                           |
| 2.10.x       | 0.63.1        | 1.33.1        |                           |
| 2.9.2        | 0.61.0        | 1.31.0        | Updated protobuf to 3.3.0 |
| 2.9.1        | 0.61.0        | 1.31.0        | Updated protobuf to 3.2.0 |
| 2.9.0        | 0.61.0        | 1.31.0        |                           |
| 2.8.0        | 0.59.1        | 1.29.1        |                           |
| 2.7.0        | 0.57.2        | 1.27.2        |                           |
| 2.6.x        | 0.55.0        | 1.25.0        |                           |
| 2.5.x        | 0.53.1        | 1.23.1        |                           |
| 2.4.x        | 0.51.0        | 1.21.0        |                           |
| 2.3.0        | 0.49.1        | 1.19.1        |                           |
| 2.2.0        | 0.47.1        | 1.17.0        |                           |
| 2.1.0        | 0.45.0        | 1.15.0        |                           |
| 2.1.0-beta   | 0.45.0        | 1.15.0        |                           |
| 2.0.x        | 0.43.4        | 1.13.4        |                           |

### CREDITS

 - [AeonLucid](https://github.com/AeonLucid)
 - [pogosandbox (niicojs)](https://github.com/pogosandbox)
 - [ZeChrales](https://github.com/ZeChrales)
