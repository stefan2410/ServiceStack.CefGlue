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
    internal unsafe struct cef_audio_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_audio_stream_started;
        internal IntPtr _on_audio_stream_packet;
        internal IntPtr _on_audio_stream_stopped;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_audio_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_audio_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_audio_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_audio_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_audio_stream_started_delegate(cef_audio_handler_t* self, cef_browser_t* browser, int audio_stream_id, int channels, CefChannelLayout channel_layout, int sample_rate, int frames_per_buffer);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_audio_stream_packet_delegate(cef_audio_handler_t* self, cef_browser_t* browser, int audio_stream_id, float** data, int frames, long pts);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_audio_stream_stopped_delegate(cef_audio_handler_t* self, cef_browser_t* browser, int audio_stream_id);
        
        private static int _sizeof;
        
        static cef_audio_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_audio_handler_t));
        }
        
        internal static cef_audio_handler_t* Alloc()
        {
            var ptr = (cef_audio_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_audio_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_audio_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
