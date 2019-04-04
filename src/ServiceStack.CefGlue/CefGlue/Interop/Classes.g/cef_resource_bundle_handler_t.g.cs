//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_resource_bundle_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _get_localized_string;
        internal IntPtr _get_data_resource;
        internal IntPtr _get_data_resource_for_scale;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_resource_bundle_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_resource_bundle_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_resource_bundle_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_resource_bundle_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_localized_string_delegate(cef_resource_bundle_handler_t* self, int string_id, cef_string_t* @string);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_data_resource_delegate(cef_resource_bundle_handler_t* self, int resource_id, void** data, UIntPtr* data_size);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_data_resource_for_scale_delegate(cef_resource_bundle_handler_t* self, int resource_id, CefScaleFactor scale_factor, void** data, UIntPtr* data_size);
        
        private static int _sizeof;
        
        static cef_resource_bundle_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_resource_bundle_handler_t));
        }
        
        internal static cef_resource_bundle_handler_t* Alloc()
        {
            var ptr = (cef_resource_bundle_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_resource_bundle_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_resource_bundle_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
