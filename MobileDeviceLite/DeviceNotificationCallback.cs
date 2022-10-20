using System.Runtime.InteropServices;

namespace MK.MobileDevice.Lite
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void DeviceNotificationCallback(ref AMDeviceNotificationCallbackInfo callback_info);
    internal delegate void ITMDDeviceNotificationCallback(ref ITMDAMDeviceNotificationCallbackInfo callback_info);
}

