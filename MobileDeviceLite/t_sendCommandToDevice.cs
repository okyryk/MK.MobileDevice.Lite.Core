using System.Runtime.InteropServices;

namespace MK.MobileDevice.Lite
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate uint t_sendCommandToDevice(IntPtr conn, IntPtr cfs, int block);
}

