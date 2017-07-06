﻿using Net.Chdk.Meta.Model.CameraTree;
using Net.Chdk.Meta.Providers.Csv;
using System.Collections.Generic;
using System.IO;

namespace Net.Chdk.Meta.Providers.CameraTree.Csv
{
    sealed class CsvCameraTreeProvider : CsvCameraProvider<TreePlatformData, TreeRevisionData, TreeSourceData>, ICameraTreeProvider
    {
        public IDictionary<string, TreePlatformData> GetCameraTree(Stream stream)
        {
            return GetCameras(stream);
        }
    }
}
