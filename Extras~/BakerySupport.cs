using Chatroom.Core;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chatroom.Sdk.Extras
{
    internal static class BakerySupport 
    {
        [MenuItem("Connect Chat/Extras/Copy Bakery Lighting")]
        private static void CopyBakeryLighting()
        {
            var scene = SceneManager.GetActiveScene();
            var ftraceLightmaps = FindFtraceLightmaps(scene);
            if (!ftraceLightmaps)
            {
                Debug.LogWarning("No !ftraceLightmaps object in the scene.");
                return;
            }

            var storage = ftraceLightmaps.GetComponentInChildren<ftLightmapsStorage>(); 
            if (!storage)
            {
                Debug.LogWarning($"No {nameof(ftLightmapsStorage)} object in the scene.");
                return;
            }

            var lighting = Object.FindObjectOfType<CC_Lighting>();
            if (!lighting)
            {
                var gameObject = new GameObject("!ccLighting");
                lighting = gameObject.AddComponent<CC_Lighting>();
                Debug.Log($"Created {nameof(CC_Lighting)} object.");
            }

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

        private static GameObject FindFtraceLightmaps(Scene scene)
        {
            GameObject ftraceLightmaps = null;
            foreach (var rootGameObject in scene.GetRootGameObjects())
            {
                if (rootGameObject.name == "!ftraceLightmaps")
                {
                    ftraceLightmaps = rootGameObject;
                    break;
                }
            }

            return ftraceLightmaps;
        }
    }
}