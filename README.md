# UnityFileIOUtility

**FileIOUtility.cs** is a simple script helps process file I/O in Unity. There is a **Test_FileIOUtility** sample scene showing how to use this script.

How to Use
---
`FileIOUtility` is a public static class so you can simply access it from any other scripts.

Scripting Reference
---
```csharp
public static string GenerateFileName(string _prefix, int _index, FileExtension _extension)
```
generates a filename with your disired prefix string, index (useful for counting players in my case), file extension(currently I need only png and jpg) and system date time. For instance, calling `GenerateFileName("MyPicture", 23, FileExtension.PNG)` returns "MyPicture_00012_03-28_21-02-30.png".
```csharp
public static void SaveImage(Texture2D _texture, string _path, string _fileName, FileExtension _extension)
```
saves a Texture2D with specified filename and extension to a path.
```csharp
public static bool DoesPathExist(string _path)
```
checks if a path exists.
```csharp
 public static bool IsFileLocked(string _filePath)
 ```
checks if a file is locked. (The file may be unavailable because it is still be written to, or being processed by another thread, or does not exist. This is from [nikunjM's answer on Stack Overflow](https://stackoverflow.com/questions/46915165/error-when-using-itext-the-process-cannot-access-the-file-because-it-is-being-u))

Note
---
This project use Git submodule [gm_FileIOUtility](https://github.com/GimChuang/gm_FileIOUtility). You need to call
```
git clone --recurse-submodules <URL>
``` 
when you clone this reposiory.

