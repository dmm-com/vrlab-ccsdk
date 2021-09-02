# Supported Unity Components and Shaders

## Allowed Components

The following components can be used when creating your world:

- UnityEngine.AI.NavMeshAgent
- UnityEngine.AI.NavMeshObstacle
- UnityEngine.AI.OffMeshLink
- UnityEngine.Animator
- UnityEngine.AudioChorusFilter
- UnityEngine.AudioDistortionFilter
- UnityEngine.AudioEchoFilter
- UnityEngine.AudioHighPassFilter
- UnityEngine.AudioLowPassFilter
- UnityEngine.AudioReverbFilter
- UnityEngine.AudioReverbZone
- UnityEngine.AudioSource
- UnityEngine.BillboardRenderer
- UnityEngine.BoxCollider
- UnityEngine.Camera
- UnityEngine.Canvas
- UnityEngine.CanvasGroup
- UnityEngine.CanvasRenderer
- UnityEngine.CapsuleCollider
- UnityEngine.CharacterController
- UnityEngine.Collider
- UnityEngine.Grid
- UnityEngine.GridLayout
- UnityEngine.Light
- UnityEngine.LightProbeGroup
- UnityEngine.LightProbeProxyVolume
- UnityEngine.LineRenderer
- UnityEngine.LODGroup
- UnityEngine.MeshCollider
- UnityEngine.MeshFilter
- UnityEngine.MeshRenderer
- UnityEngine.OcclusionArea
- UnityEngine.OcclusionPortal
- UnityEngine.ParticleSystem
- UnityEngine.ParticleSystemForceField
- UnityEngine.ParticleSystemRenderer
- UnityEngine.Projector
- UnityEngine.RectTransform
- UnityEngine.ReflectionProbe
- UnityEngine.Renderer
- UnityEngine.Rendering.SortingGroup
- UnityEngine.Rigidbody
- UnityEngine.SkinnedMeshRenderer
- UnityEngine.SphereCollider
- UnityEngine.SpringJoint
- UnityEngine.SpriteMask
- UnityEngine.SpriteRenderer
- UnityEngine.Terrain
- UnityEngine.TerrainCollider
- UnityEngine.TextMesh
- UnityEngine.Tilemaps.Tilemap
- UnityEngine.Tilemaps.TilemapRenderer
- UnityEngine.TrailRenderer
- UnityEngine.Transform
- UnityEngine.Tree
- UnityEngine.UI.AspectRatioFitter
- UnityEngine.UI.BaseMeshEffect
- UnityEngine.UI.Button
- UnityEngine.UI.CanvasScaler
- UnityEngine.UI.ContentSizeFitter
- UnityEngine.UI.Dropdown
- UnityEngine.UI.Graphic
- UnityEngine.UI.GraphicRaycaster
- UnityEngine.UI.GridLayoutGroup
- UnityEngine.UI.HorizontalLayoutGroup
- UnityEngine.UI.HorizontalOrVerticalLayoutGroup
- UnityEngine.UI.Image
- UnityEngine.UI.InputField
- UnityEngine.UI.LayoutElement
- UnityEngine.UI.LayoutGroup
- UnityEngine.UI.Mask
- UnityEngine.UI.MaskableGraphic
- UnityEngine.UI.Outline
- UnityEngine.UI.PositionAsUV1
- UnityEngine.UI.RawImage
- UnityEngine.UI.RectMask2D
- UnityEngine.UI.Scrollbar
- UnityEngine.UI.ScrollRect
- UnityEngine.UI.Selectable
- UnityEngine.UI.Shadow
- UnityEngine.UI.Slider
- UnityEngine.UI.Text
- UnityEngine.UI.Toggle
- UnityEngine.UI.ToggleGroup
- UnityEngine.UI.VerticalLayoutGroup
- UnityEngine.WheelCollider
- UnityEngine.WindZone

:warning: Using a component not in the list will result in an error when uploading your world.

## Allowed Shaders

The following shaders can be used when creating your world.

- Mobile/Bumped Diffuse
- Mobile/Bumped Specular
- Mobile/Diffuse
- Mobile/Particles/Additive
- Mobile/Particles/Alpha Blended
- Mobile/Particles/Multiply
- Mobile/Particles/VertexLit Blended
- Mobile/Skybox
- Mobile/Unlit (Supports Lightmap)
- Mobile/VertexLit
- Mobile/VertexLit (Only Directional Lights)
- Standard
- Standard (Specular setup)
- UI/Default
- Unlit/Color
- Unlit/Texture
- Unlit/Transparent
- Unlit/Transparent Cutout
- Particles/Standard Surface
- Particles/Standard Unlit

:warning: Using a shader not in the list will result in an error when uploading your world.

## Third-party Assets

### Bakery

Lightmaps baked by Bakery can be used in your worlds.
To do so:

1. Copy the `BakerySupport.cs` file in the `Extras~` folder into your project's `Editor` folder.
2. Bake your lightmaps and probes with Bakery (we do not support SH and RMP lightmaps).
3. Select `Connect Chat > Extras > Copy Bakery Lightmaps` from the menu. This will create a new object in your scene and
   initialize it using Bakery's lightmaps settings.
4. Disable all Bakery related gameobjects.
5. Build and upload your world.
