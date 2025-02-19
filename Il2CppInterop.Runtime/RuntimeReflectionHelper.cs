using System;
using System.Linq;
using Il2CppSystem.Reflection;
using RuntimeTypeHandle = Il2CppSystem.RuntimeTypeHandle;
using Type = Il2CppSystem.Type;

namespace Il2CppInterop.Runtime;

public static class RuntimeReflectionHelper
{
    public static IntPtr GetNestedTypeViaReflection(IntPtr enclosingClass, string nestedTypeName)
    {
        var reflectionType = Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(enclosingClass));
        var nestedType = reflectionType.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic).FirstOrDefault(x => x.Name == nestedTypeName);

        return nestedType != null ? IL2CPP.il2cpp_class_from_system_type(nestedType.Pointer) : IntPtr.Zero;
    }

    public static RuntimeTypeHandle GetRuntimeTypeHandle<T>()
    {
        return Il2CppType.Of<T>().TypeHandle;
    }
}
