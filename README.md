# IRL Fontbook

Html generator for printable fontbooks

![](media/screenshot.png)

## Usage

```
git clone https://github.com/jogleasonjr/irl_fontbook.git
cd irl_fontbook
dotnet run
```

The program will output the path to an HTML file in the user's temp directory.

## macOS Catalina and dotnet 3.1.3

Something with libgdiplus [is broken](https://github.com/dotnet/runtime/issues/32911) and this link must be created:

`sudo ln -s /usr/local/lib/libgdiplus.dylib /usr/local/share/dotnet/shared/Microsoft.NETCore.App/3.1.3`
