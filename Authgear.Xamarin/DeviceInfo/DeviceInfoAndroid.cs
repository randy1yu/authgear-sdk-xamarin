﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Authgear.Xamarin
{
    public partial class DeviceInfoAndroid
    {
        [JsonPropertyName("Build")]
        public DeviceInfoAndroidBuild Build { get; set; }
        [JsonPropertyName("PackageInfo")]
        public DeviceInfoAndroidPackageInfo PackageInfo { get; set; }
        [JsonPropertyName("Settings")]
        public DeviceInfoAndroidSettings Settings { get; set; }
        private DeviceInfoAndroid()
        {
        }
    }
}
