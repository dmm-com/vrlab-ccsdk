# 対応コンポーネント・シェーダー

## 対応コンポーネント

ワールド作成の際、下記のコンポーネントがご利用いただけます:

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

＊上記のリストにないコンポーネントを使用した場合、ワールドのアップロード時にエラーが起きます。

## 対応シェーダー

ワールド作成の際、下記のシェーダーがご利用いただけます:

- Mobile/Bumped Diffuse
- Mobile/Bumped Specular
- Mobile/Diffuse
- Mobile/Particles/Additive
- Mobile/Particles/Alpha Blended
- Mobile/Particles/Multiply
- Mobile/Particles/VertexLit Blended
- Mobile/Skybox
- Mobile/Unlit (Lightmap対応)
- Mobile/VertexLit
- Mobile/VertexLit (Directional Lightsのみ対応)
- Standard
- Standard (Specular setup)
- UI/Default
- Unlit/Color
- Unlit/Texture
- Unlit/Transparent
- Unlit/Transparent Cutout

＊上記のリストにないシェーダーを使用した場合、ワールドのアップロード時にエラーが起きます。

## サードパーティのアセット

### Bakery

Bakeryでベイクしたライトマップをワールドに使用可能です。

手順:

1. `Extras~`フォルダにある`BakerySupport.cs`ファイルをプロジェクトの`Editor`フォルダにコピーします。
2. Bakeryでライトマップとプローブをベイクします (SHとRMPライトマップはサポートしていません)。
3. メニューの`Connect Chat > Extras > Copy Bakery Lightmaps`を選択すると、シーンに新しいオブジェクトが生成され、Bakeryのライトマップ設定で初期化されます。
4. すべてのBakery関連のゲームオブジェクトを無効にします・。
5. ワールドをビルドしてアップロードします。