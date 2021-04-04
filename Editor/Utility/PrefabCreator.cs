namespace Tilia.CameraRigs.SpatialSimulator.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "CameraRigs/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.camerarigs.spatialsimulator.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCameraRigsSpatialSimulator = "CameraRigs.SpatialSimulator";

        [MenuItem(menuItemRoot + prefabCameraRigsSpatialSimulator, false, priority)]
        private static void AddCameraRigsSpatialSimulator()
        {
            string prefab = prefabCameraRigsSpatialSimulator + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}