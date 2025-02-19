using Microsoft.Extensions.Logging;

namespace Il2CppInterop.Common;

public static class NativeExtensions
{
    public static bool TargetProcessIs64Bit { get; set; } = Environment.Is64BitProcess;

    static NativeExtensions()
    {
        Logger.Instance.LogDebug("TargetProcessIs64Bit: {Is64Bit}", TargetProcessIs64Bit);
    }

    public static IntPtr ToIntPtrChecked(this ulong addr)
    {
        return TargetProcessIs64Bit
            ? (IntPtr)addr
            : (IntPtr)(int)checked((uint)addr);
    }

    public static IntPtr ToIntPtrChecked(this long addr)
    {
        return TargetProcessIs64Bit
            ? (IntPtr)addr
            : (IntPtr)(int)checked((uint)addr);
    }
}
