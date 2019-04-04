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
    internal unsafe struct cef_print_settings_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _is_valid;
        internal IntPtr _is_read_only;
        internal IntPtr _copy;
        internal IntPtr _set_orientation;
        internal IntPtr _is_landscape;
        internal IntPtr _set_printer_printable_area;
        internal IntPtr _set_device_name;
        internal IntPtr _get_device_name;
        internal IntPtr _set_dpi;
        internal IntPtr _get_dpi;
        internal IntPtr _set_page_ranges;
        internal IntPtr _get_page_ranges_count;
        internal IntPtr _get_page_ranges;
        internal IntPtr _set_selection_only;
        internal IntPtr _is_selection_only;
        internal IntPtr _set_collate;
        internal IntPtr _will_collate;
        internal IntPtr _set_color_model;
        internal IntPtr _get_color_model;
        internal IntPtr _set_copies;
        internal IntPtr _get_copies;
        internal IntPtr _set_duplex_mode;
        internal IntPtr _get_duplex_mode;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_print_settings_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_print_settings_t* create();
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_valid_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_read_only_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_print_settings_t* copy_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_orientation_delegate(cef_print_settings_t* self, int landscape);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_landscape_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_printer_printable_area_delegate(cef_print_settings_t* self, cef_size_t* physical_size_device_units, cef_rect_t* printable_area_device_units, int landscape_needs_flip);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_device_name_delegate(cef_print_settings_t* self, cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_device_name_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_dpi_delegate(cef_print_settings_t* self, int dpi);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_dpi_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_page_ranges_delegate(cef_print_settings_t* self, UIntPtr rangesCount, cef_range_t* ranges);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate UIntPtr get_page_ranges_count_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_page_ranges_delegate(cef_print_settings_t* self, UIntPtr* rangesCount, cef_range_t* ranges);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_selection_only_delegate(cef_print_settings_t* self, int selection_only);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_selection_only_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_collate_delegate(cef_print_settings_t* self, int collate);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int will_collate_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_color_model_delegate(cef_print_settings_t* self, CefColorModel model);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefColorModel get_color_model_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_copies_delegate(cef_print_settings_t* self, int copies);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_copies_delegate(cef_print_settings_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_duplex_mode_delegate(cef_print_settings_t* self, CefDuplexMode mode);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefDuplexMode get_duplex_mode_delegate(cef_print_settings_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_print_settings_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_print_settings_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_print_settings_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // HasAtLeastOneRef
        private static IntPtr _p3;
        private static has_at_least_one_ref_delegate _d3;
        
        public static int has_at_least_one_ref(cef_print_settings_t* self)
        {
            has_at_least_one_ref_delegate d;
            var p = self->_base._has_at_least_one_ref;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (has_at_least_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_at_least_one_ref_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // IsValid
        private static IntPtr _p4;
        private static is_valid_delegate _d4;
        
        public static int is_valid(cef_print_settings_t* self)
        {
            is_valid_delegate d;
            var p = self->_is_valid;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (is_valid_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_valid_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // IsReadOnly
        private static IntPtr _p5;
        private static is_read_only_delegate _d5;
        
        public static int is_read_only(cef_print_settings_t* self)
        {
            is_read_only_delegate d;
            var p = self->_is_read_only;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (is_read_only_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_read_only_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // Copy
        private static IntPtr _p6;
        private static copy_delegate _d6;
        
        public static cef_print_settings_t* copy(cef_print_settings_t* self)
        {
            copy_delegate d;
            var p = self->_copy;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (copy_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(copy_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // SetOrientation
        private static IntPtr _p7;
        private static set_orientation_delegate _d7;
        
        public static void set_orientation(cef_print_settings_t* self, int landscape)
        {
            set_orientation_delegate d;
            var p = self->_set_orientation;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (set_orientation_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_orientation_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            d(self, landscape);
        }
        
        // IsLandscape
        private static IntPtr _p8;
        private static is_landscape_delegate _d8;
        
        public static int is_landscape(cef_print_settings_t* self)
        {
            is_landscape_delegate d;
            var p = self->_is_landscape;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (is_landscape_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_landscape_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // SetPrinterPrintableArea
        private static IntPtr _p9;
        private static set_printer_printable_area_delegate _d9;
        
        public static void set_printer_printable_area(cef_print_settings_t* self, cef_size_t* physical_size_device_units, cef_rect_t* printable_area_device_units, int landscape_needs_flip)
        {
            set_printer_printable_area_delegate d;
            var p = self->_set_printer_printable_area;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (set_printer_printable_area_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_printer_printable_area_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            d(self, physical_size_device_units, printable_area_device_units, landscape_needs_flip);
        }
        
        // SetDeviceName
        private static IntPtr _pa;
        private static set_device_name_delegate _da;
        
        public static void set_device_name(cef_print_settings_t* self, cef_string_t* name)
        {
            set_device_name_delegate d;
            var p = self->_set_device_name;
            if (p == _pa) { d = _da; }
            else
            {
                d = (set_device_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_device_name_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            d(self, name);
        }
        
        // GetDeviceName
        private static IntPtr _pb;
        private static get_device_name_delegate _db;
        
        public static cef_string_userfree* get_device_name(cef_print_settings_t* self)
        {
            get_device_name_delegate d;
            var p = self->_get_device_name;
            if (p == _pb) { d = _db; }
            else
            {
                d = (get_device_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_device_name_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            return d(self);
        }
        
        // SetDPI
        private static IntPtr _pc;
        private static set_dpi_delegate _dc;
        
        public static void set_dpi(cef_print_settings_t* self, int dpi)
        {
            set_dpi_delegate d;
            var p = self->_set_dpi;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (set_dpi_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_dpi_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            d(self, dpi);
        }
        
        // GetDPI
        private static IntPtr _pd;
        private static get_dpi_delegate _dd;
        
        public static int get_dpi(cef_print_settings_t* self)
        {
            get_dpi_delegate d;
            var p = self->_get_dpi;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (get_dpi_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_dpi_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            return d(self);
        }
        
        // SetPageRanges
        private static IntPtr _pe;
        private static set_page_ranges_delegate _de;
        
        public static void set_page_ranges(cef_print_settings_t* self, UIntPtr rangesCount, cef_range_t* ranges)
        {
            set_page_ranges_delegate d;
            var p = self->_set_page_ranges;
            if (p == _pe) { d = _de; }
            else
            {
                d = (set_page_ranges_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_page_ranges_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            d(self, rangesCount, ranges);
        }
        
        // GetPageRangesCount
        private static IntPtr _pf;
        private static get_page_ranges_count_delegate _df;
        
        public static UIntPtr get_page_ranges_count(cef_print_settings_t* self)
        {
            get_page_ranges_count_delegate d;
            var p = self->_get_page_ranges_count;
            if (p == _pf) { d = _df; }
            else
            {
                d = (get_page_ranges_count_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_page_ranges_count_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            return d(self);
        }
        
        // GetPageRanges
        private static IntPtr _p10;
        private static get_page_ranges_delegate _d10;
        
        public static void get_page_ranges(cef_print_settings_t* self, UIntPtr* rangesCount, cef_range_t* ranges)
        {
            get_page_ranges_delegate d;
            var p = self->_get_page_ranges;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (get_page_ranges_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_page_ranges_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            d(self, rangesCount, ranges);
        }
        
        // SetSelectionOnly
        private static IntPtr _p11;
        private static set_selection_only_delegate _d11;
        
        public static void set_selection_only(cef_print_settings_t* self, int selection_only)
        {
            set_selection_only_delegate d;
            var p = self->_set_selection_only;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (set_selection_only_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_selection_only_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            d(self, selection_only);
        }
        
        // IsSelectionOnly
        private static IntPtr _p12;
        private static is_selection_only_delegate _d12;
        
        public static int is_selection_only(cef_print_settings_t* self)
        {
            is_selection_only_delegate d;
            var p = self->_is_selection_only;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (is_selection_only_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_selection_only_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            return d(self);
        }
        
        // SetCollate
        private static IntPtr _p13;
        private static set_collate_delegate _d13;
        
        public static void set_collate(cef_print_settings_t* self, int collate)
        {
            set_collate_delegate d;
            var p = self->_set_collate;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (set_collate_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_collate_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            d(self, collate);
        }
        
        // WillCollate
        private static IntPtr _p14;
        private static will_collate_delegate _d14;
        
        public static int will_collate(cef_print_settings_t* self)
        {
            will_collate_delegate d;
            var p = self->_will_collate;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (will_collate_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(will_collate_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            return d(self);
        }
        
        // SetColorModel
        private static IntPtr _p15;
        private static set_color_model_delegate _d15;
        
        public static void set_color_model(cef_print_settings_t* self, CefColorModel model)
        {
            set_color_model_delegate d;
            var p = self->_set_color_model;
            if (p == _p15) { d = _d15; }
            else
            {
                d = (set_color_model_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_color_model_delegate));
                if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
            }
            d(self, model);
        }
        
        // GetColorModel
        private static IntPtr _p16;
        private static get_color_model_delegate _d16;
        
        public static CefColorModel get_color_model(cef_print_settings_t* self)
        {
            get_color_model_delegate d;
            var p = self->_get_color_model;
            if (p == _p16) { d = _d16; }
            else
            {
                d = (get_color_model_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_color_model_delegate));
                if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
            }
            return d(self);
        }
        
        // SetCopies
        private static IntPtr _p17;
        private static set_copies_delegate _d17;
        
        public static void set_copies(cef_print_settings_t* self, int copies)
        {
            set_copies_delegate d;
            var p = self->_set_copies;
            if (p == _p17) { d = _d17; }
            else
            {
                d = (set_copies_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_copies_delegate));
                if (_p17 == IntPtr.Zero) { _d17 = d; _p17 = p; }
            }
            d(self, copies);
        }
        
        // GetCopies
        private static IntPtr _p18;
        private static get_copies_delegate _d18;
        
        public static int get_copies(cef_print_settings_t* self)
        {
            get_copies_delegate d;
            var p = self->_get_copies;
            if (p == _p18) { d = _d18; }
            else
            {
                d = (get_copies_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_copies_delegate));
                if (_p18 == IntPtr.Zero) { _d18 = d; _p18 = p; }
            }
            return d(self);
        }
        
        // SetDuplexMode
        private static IntPtr _p19;
        private static set_duplex_mode_delegate _d19;
        
        public static void set_duplex_mode(cef_print_settings_t* self, CefDuplexMode mode)
        {
            set_duplex_mode_delegate d;
            var p = self->_set_duplex_mode;
            if (p == _p19) { d = _d19; }
            else
            {
                d = (set_duplex_mode_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_duplex_mode_delegate));
                if (_p19 == IntPtr.Zero) { _d19 = d; _p19 = p; }
            }
            d(self, mode);
        }
        
        // GetDuplexMode
        private static IntPtr _p1a;
        private static get_duplex_mode_delegate _d1a;
        
        public static CefDuplexMode get_duplex_mode(cef_print_settings_t* self)
        {
            get_duplex_mode_delegate d;
            var p = self->_get_duplex_mode;
            if (p == _p1a) { d = _d1a; }
            else
            {
                d = (get_duplex_mode_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_duplex_mode_delegate));
                if (_p1a == IntPtr.Zero) { _d1a = d; _p1a = p; }
            }
            return d(self);
        }
        
    }
}
