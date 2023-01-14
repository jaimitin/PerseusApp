namespace Perseus.App.Util
{
    public static class DeviceUtil
    {
        private static IDeviceInfo DeviceInfo => Microsoft.Maui.Devices.DeviceInfo.Current;
        private static DevicePlatform Platform => DeviceInfo.Platform;

        private static bool IsPlatform(DevicePlatform platform)
        {
            return Platform == platform;
        }

        /// <summary>
        /// Whether the current runtime platform is iOS
        /// </summary>
        public static bool IsIOS => IsPlatform(DevicePlatform.iOS);

        /// <summary>
        /// Whether the current runtime platform is Android
        /// </summary>
        public static bool IsAndroid => IsPlatform(DevicePlatform.Android);
    }
}
