using Chatroom.Core;
using UnityEditor;
using UnityEngine;

namespace Chatroom.Sdk.Extras
{
    internal static class BakerySupport 
    {
        [MenuItem("Connect Chat/Extras/Copy Bakery Lightmaps")]
        private static void CopyBakeryLighting()
        {
            var storageList = Object.FindObjectsOfType<ftLightmapsStorage>();
            if (storageList.Length == 0)
            {
                Debug.LogWarning($"No {nameof(ftLightmapsStorage)} object in the scene.");
                return;
            }
            if (storageList.Length > 1)
            {
                Debug.LogError($"Multiple {nameof(ftLightmapsStorage)} objects in the scene.");
                return;
            }

            var lighting = Object.FindObjectOfType<CC_Lighting>();
            if (!lighting)
            {
                var gameObject = new GameObject("!ccLighting");
                lighting = gameObject.AddComponent<CC_Lighting>();
                Debug.Log($"Created {nameof(CC_Lighting)} object.");
            }

            var storage = storageList[0];
            
            ftLightmaps.RefreshScene(storage.gameObject.scene, storage);
            lighting.BakedRenderers = storage.bakedRenderers.ToArray();
            lighting.BakedTerrains = storage.bakedRenderersTerrain.ToArray();
            lighting.LightmapsColor = storage.maps.ToArray();
            lighting.LightmapsDir = storage.dirMaps.ToArray();
            lighting.ShadowMasks = storage.masks.ToArray();
            lighting.BakedLightmapIndices = storage.bakedIDs.ToArray();
            lighting.EmptyLightmapDir = storage.emptyDirectionTex;
            lighting.BakedLightmapScaleOffset = storage.bakedScaleOffset.ToArray();
            lighting.BakedTerrainLightmapIndices = storage.bakedIDsTerrain.ToArray();
            lighting.BakedTerrainLightmapScaleOffset = storage.bakedScaleOffsetTerrain.ToArray();
            EditorUtility.SetDirty(lighting);
        }
    }
}