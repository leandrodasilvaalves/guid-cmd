# Guid-Cmd

## Project Description

Guid-Cmd is a command line tool to generate Globally Unique Identifier (GUID)/ Universally unique identifier (Uuid).
## Give a Star! ⭐
If you liked the project or if Guid-Cmd helped you, please give a star ;)

## Requirements

Make sure you have .NET 7 installed on your system.

## Installation
Download the latest version according to your operating system [**here**](hhttps://github.com/leandrodasilvaalves/guid-cmd/releases).

> Assuming 1.0.0 is the latest version

### Linux

```bash
  cd ~/Downloads
  tar -xvf GuidCmd.linux.tar.gz
  chmod +x GuidCmd.1.0.0/guid #change 1.0.0 to your version
  sudo mv GuidCmd.1.0.0/ /guid/local/share/guid #change 1.0.0 to your version
  sudo ln -s /usr/local/share/guid/guid /usr/local/bin/guid
  guid
> 7fefa6e3-6045-4f00-930d-15b0991cc430
```

### windows
Extract the downloaded binaries to the directory of your choice, for example, `c:\guid` and include this directory in your path according to the step by step [**here**](https://learn.microsoft.com/en-us/previous-versions/office/developer/sharepoint-2010/ee537574(v=office.14)#to-add-a-path-to-the-path-environment-variable).

Ater that open a terminal and type `guid`. You should see a generated number that looks like this: `f745fa88-dd2a-49de-b040-c464df0881cf`

## How to use
```bash
  guid 
  > b9fa4c85-92b8-414b-ad64-d30178171d75
  guid --no-dash
  > 4bc8b6e07112421f8c290c2d6f458075
  guid -n 5
  > b927479b-091a-4bfe-aab2-4ff75120dc52
    336b0358-9314-4ba8-8937-64cae85066b9
    7281e1ef-3e67-4ed7-bb41-a3805ce58153
    a53241ac-8652-445f-8dab-7c0ec22a0325
    ff39f80a-96bc-4115-9627-dd5e14e8e3f2
```

## Contribution
This project is open source and contributions are welcome! Feel free to open issues and submit pull requests.

## License
The Guid-Cmd Project was developed by [Leandro Alves](https://github.com/leandrodasilvaalves) under the MIT license.