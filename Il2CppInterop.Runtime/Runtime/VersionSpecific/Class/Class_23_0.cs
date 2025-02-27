using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
    [ApplicableToUnityVersionsSince("5.6.0")]
    public unsafe class NativeClassStructHandler_23_0 : INativeClassStructHandler
    {
        private static readonly int s_part1Part2PaddingSize = Environment.Is64BitProcess ? 0 : 4;

        public int Size() => sizeof(Il2CppClass_23_0__Part1) + sizeof(Il2CppClass_23_0__Part2) + s_part1Part2PaddingSize;
        public INativeClassStruct CreateNewStruct(int vTableSlots)
        {
            IntPtr ptr = Marshal.AllocHGlobal(Size() + sizeof(VirtualInvokeData) * vTableSlots);
            Il2CppClass_23_0__Part1* p1 = (Il2CppClass_23_0__Part1*)ptr;
            Il2CppClass_23_0__Part2* p2 = (Il2CppClass_23_0__Part2*)(ptr + sizeof(Il2CppClass_23_0__Part1) + s_part1Part2PaddingSize);
            *p1 = default;
            *p2 = default;
            p1->byval_arg = UnityVersionHandler.NewType().TypePointer;
            p1->this_arg = UnityVersionHandler.NewType().TypePointer;
            return new NativeStructWrapper((IntPtr)p1);
        }
        public INativeClassStruct Wrap(Il2CppClass* ptr)
        {
            if (ptr == null) return null;
            var p = (IntPtr)ptr;
            return new NativeStructWrapper(p);
        }

        // Memory layout:
        // | Il2CppClass_23_0__Part1 | padding | Il2CppClass_23_0__Part2 |
        // padding size is determined by the process architecture
        internal unsafe struct Il2CppClass_23_0__Part1
        {
            public Il2CppImage* image;
            public void* gc_desc;
            public byte* name;
            public byte* namespaze;
            public Il2CppTypeStruct* byval_arg;
            public Il2CppTypeStruct* this_arg;
            public Il2CppClass* element_class;
            public Il2CppClass* castClass;
            public Il2CppClass* declaringType;
            public Il2CppClass* parent;
            public void* generic_class;
            public void* typeDefinition;
            public void* interopData;
            public Il2CppFieldInfo* fields;
            public Il2CppEventInfo* events;
            public Il2CppPropertyInfo* properties;
            public Il2CppMethodInfo** methods;
            public Il2CppClass** nestedTypes;
            public Il2CppClass** implementedInterfaces;
            public Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;
            public void* static_fields;
            public void* rgctx_data;
            public Il2CppClass** typeHierarchy;
            public uint cctor_started;
            public uint cctor_finished;
        }

        internal unsafe struct Il2CppClass_23_0__Part2
        {
            /* #if IS_32BIT
             *     uint32_t cctor_thread__padding;
             * #endif
             */

            // aligned(8)
            public ulong cctor_thread;
            public int genericContainerIndex;
            public int customAttributeIndex;
            public uint instance_size;
            public uint actualSize;
            public uint element_size;
            public int native_size;
            public uint static_fields_size;
            public uint thread_static_fields_size;
            public int thread_static_fields_offset;
            public uint flags;
            public uint token;
            public ushort method_count;
            public ushort property_count;
            public ushort field_count;
            public ushort event_count;
            public ushort nested_type_count;
            public ushort vtable_count;
            public ushort interfaces_count;
            public ushort interface_offsets_count;
            public byte typeHierarchyDepth;
            public byte genericRecursionDepth;
            public byte rank;
            public byte minimumAlignment;
            public byte packingSize;
            public Bitfield0 _bitfield0;
            public Bitfield1 _bitfield1;
            internal enum Bitfield0 : byte
            {
                BIT_valuetype = 0,
                valuetype = (1 << BIT_valuetype),
                BIT_initialized = 1,
                initialized = (1 << BIT_initialized),
                BIT_enumtype = 2,
                enumtype = (1 << BIT_enumtype),
                BIT_is_generic = 3,
                is_generic = (1 << BIT_is_generic),
                BIT_has_references = 4,
                has_references = (1 << BIT_has_references),
                BIT_init_pending = 5,
                init_pending = (1 << BIT_init_pending),
                BIT_size_inited = 6,
                size_inited = (1 << BIT_size_inited),
                BIT_has_finalize = 7,
                has_finalize = (1 << BIT_has_finalize),
            }

            internal enum Bitfield1 : byte
            {
                BIT_has_cctor = 0,
                has_cctor = (1 << BIT_has_cctor),
                BIT_is_blittable = 1,
                is_blittable = (1 << BIT_is_blittable),
                BIT_is_import_or_windows_runtime = 2,
                is_import_or_windows_runtime = (1 << BIT_is_import_or_windows_runtime),
                BIT_is_vtable_initialized = 3,
                is_vtable_initialized = (1 << BIT_is_vtable_initialized),
            }
        }

        internal class NativeStructWrapper(IntPtr ptr) : INativeClassStruct
        {
            private static int _bitfield0offset = sizeof(Il2CppClass_23_0__Part1) + s_part1Part2PaddingSize +
                                                  Marshal.OffsetOf<Il2CppClass_23_0__Part2>(nameof(Il2CppClass_23_0__Part2._bitfield0)).ToInt32();
            private static int _bitfield1offset = sizeof(Il2CppClass_23_0__Part1) + s_part1Part2PaddingSize +
                                                  Marshal.OffsetOf<Il2CppClass_23_0__Part2>(nameof(Il2CppClass_23_0__Part2._bitfield1)).ToInt32();
            private Il2CppClass* _klassDummy;
            public IntPtr Pointer { get; } = ptr;
            private Il2CppClass_23_0__Part1* _ => (Il2CppClass_23_0__Part1*)Pointer;
            private Il2CppClass_23_0__Part2* _p2 => (Il2CppClass_23_0__Part2*)(Pointer + sizeof(Il2CppClass_23_0__Part1) + s_part1Part2PaddingSize);
            public IntPtr VTable => IntPtr.Add(Pointer, sizeof(Il2CppClass_23_0__Part1) + sizeof(Il2CppClass_23_0__Part2) + s_part1Part2PaddingSize);
            public Il2CppClass* ClassPointer => (Il2CppClass*)Pointer;
            public INativeTypeStruct ByValArg => UnityVersionHandler.Wrap(_->byval_arg);
            public INativeTypeStruct ThisArg => UnityVersionHandler.Wrap(_->this_arg);
            public ref uint InstanceSize => ref _p2->instance_size;
            public ref ushort VtableCount => ref _p2->vtable_count;
            public ref ushort InterfaceCount => ref _p2->interfaces_count;
            public ref ushort InterfaceOffsetsCount => ref _p2->interface_offsets_count;
            public ref byte TypeHierarchyDepth => ref _p2->typeHierarchyDepth;
            public ref int NativeSize => ref _p2->native_size;
            public ref uint ActualSize => ref _p2->actualSize;
            public ref ushort MethodCount => ref _p2->method_count;
            public ref ushort FieldCount => ref _p2->field_count;
            public ref Il2CppClassAttributes Flags => ref *(Il2CppClassAttributes*)&_p2->flags;
            public ref IntPtr Name => ref *(IntPtr*)&_->name;
            public ref IntPtr Namespace => ref *(IntPtr*)&_->namespaze;
            public ref Il2CppImage* Image => ref _->image;
            public ref Il2CppClass* Parent => ref _->parent;
            public ref Il2CppClass* ElementClass => ref _->element_class;
            public ref Il2CppClass* CastClass => ref _->castClass;
            public ref Il2CppClass* DeclaringType => ref _->declaringType;
            public ref Il2CppClass* Class => ref _klassDummy;
            public ref Il2CppFieldInfo* Fields => ref _->fields;
            public ref Il2CppMethodInfo** Methods => ref _->methods;
            public ref Il2CppClass** ImplementedInterfaces => ref _->implementedInterfaces;
            public ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets => ref _->interfaceOffsets;
            public ref Il2CppClass** TypeHierarchy => ref _->typeHierarchy;
            public bool ValueType
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_valuetype);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_valuetype, value);
            }
            public bool Initialized
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_initialized);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_initialized, value);
            }
            public bool EnumType
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_enumtype);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_enumtype, value);
            }
            public bool IsGeneric
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_is_generic);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_is_generic, value);
            }
            public bool HasReferences
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_has_references);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_has_references, value);
            }
            public bool SizeInited
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_size_inited);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_size_inited, value);
            }
            public bool HasFinalize
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_has_finalize);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_23_0__Part2.Bitfield0.BIT_has_finalize, value);
            }
            public bool IsVtableInitialized
            {
                get => this.CheckBit(_bitfield1offset, (int)Il2CppClass_23_0__Part2.Bitfield1.BIT_is_vtable_initialized);
                set => this.SetBit(_bitfield1offset, (int)Il2CppClass_23_0__Part2.Bitfield1.BIT_is_vtable_initialized, value);
            }
            public bool InitializedAndNoError
            {
                get => true;
                set { }
            }
        }

    }

}
