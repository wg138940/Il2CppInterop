using System;
using System.Runtime.InteropServices;

namespace Il2CppInterop.Runtime;

public static class PlatformUtils
{
    private static readonly Lazy<bool> s_isAndroid = new (() =>
        RuntimeInformation.RuntimeIdentifier.ToLower().Contains("android"));

    public static bool IsAndroid => s_isAndroid.Value;
}
