using System;
using System.Runtime.InteropServices;

namespace Xilium.CefGlue.Avalonia.Platform
{
    internal static class NativeExtensions
    {
        [DllImport("/usr/lib/libobjc.dylib")]
        public static extern void objc_retain(IntPtr handle);

        [DllImport("/usr/lib/libobjc.dylib")]
        public static extern void objc_release(IntPtr handle);
    }
}
