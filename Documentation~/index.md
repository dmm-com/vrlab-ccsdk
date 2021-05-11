# Overview

The Connect Chat SDK (CCSDK) is the tool that allows you to build your own worlds.

## Getting Started

### Setting up Unity

[Click here](https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe) to download and install Unity Hub.

Once Unity Hub is installed [click here](unityhub://2019.4.23f1/3f4e01f1a5ec) to install the Unity version supported by Connect Chat.

### Setting up the SDK

The SDK is distributed through GitHub as a Unity Package Manager package.
You will need Git for this, so [click here](http://git-scm.com/) to download and install it.

### Template Project

We prepared a template project that can be used as a base for your new worlds.

1. [Click here](files/vrlab-ccsdk-template.zip) to download it.
2. Create a new folder for your project, extract the file in it.
3. Launch Unity Hub and add the folder you created to the list of projects.
4. Open the new project and start creating your own world.

## Creating a World

Creating a new world is a simple process:

1. Create and setup a scene containing your world content.
2. Log into your [VR Connect](https://connect.vrlab.dmm.com) account.
3. Add a new world to your list.
4. Upload the scene.
5. Publish your world.

### Step 1 - Create and Setup the Scene

Create a new scene and populate it with the content of your world.

![Create and populate your scene.](images/scene-create.png)

When you are done, add an empty _GameObject_ and attach the _CC World_ component to it.

![Add the CC World component.](images/scene-add-cc-world.png)

Add spawn points to the scene by creating empty _GameObjects_:

![Create a spawn point.](images/scene-create-spawn-point.png)

and add them to the _CC World_'s spawn point list.

![Add the spawn point to CC World.](images/scene-add-spawn-point.png)

:warning:  Not all Unity components or shaders are usable in the scene: see [here](#allowed-components) for the list of allowed components, and [here](#allowed-shaders) for the list of allowed shaders.

### Step 2 - Log into VR Connect

1. Open the control panel using the _Connect Chat_ menu.

    ![Open the Control Panel](images/control-panel-open.png)

2. Once the control panel window appears, press the _Login_ button to login into your [VR Connect] (https://connect.vrlab.dmm.com) account.

    ![Login into Connect](images/control-panel-login.png)

3. Press the _Confirm_ button in the browser window that opened and return to Unity.

    ![Device Confirmation](images/device-confirmation.png)

4. Once logged in the control panel will show the list of world you have uploaded.

    ![Empty World List](images/empty-world-list.png)

In addition to the world list, the control panel windows show the user information and
has a few useful controls:

![Control Panel Anatomy](images/control-panel-anatomy.png)

### Step 3 - Adding a New World

Click the `+` button to create a new world; the world list will update and a new world should be added to your list:

![World Entry](images/world-entry.png)

**ID:** The internal id of the world.

**Title:** The name of the world and what is shown in the world selections screen.

**Description:** One or two short sentences describing your world.

**Public:** Shows if the world is usable by everyone or only by you (you will still be able to invite people into one instance).

The image on the right is the world's thumbnail: a 256x256 texture that will be shown together with the world title on the world selection screen.

On the far right there are four icons:

![](images/world-edit-icon.png) **Edit:** Toggles the edit mode for the world details. 

![](images/world-publish-icon.png) **Publish:** Publishes the world and make it available in the World Selection window. 

![](images/world-upload-icon.png) **Build & Upload:** Builds the world asset bundle using the current active scene and uploads it.

![](images/world-delete-icon.png) **Delete:** Deletes the world (this operation cannot be undone).

#### Editing your World Details

Click the _Edit_ button and toggle the _edit mode_ for your world.

You can now edit the title and description of your world, change its thumbnail, and toggle it's visibility flag.

![Editing the world details.](images/world-edit.png)

Custom thumbnails must be 256 x 256 pixels and be imported with the following settings:

![Thumnbail import settings.](images/world-thumbnail-import-settings.png)

### Step 4 - Uploading

To building and uploading your world just click on the build button: a dialog will appear once the upload is completed.
If anything wrong happens (for example, the scene contains components that are not allowed), check the console for error messages.

### Step 5 - Publish your World

Once the details of your world are in order and the scene has been uploaded press the publish button to make your world usable in Connect Chat.

## Allowed Components and Shaders

### Allowed Components

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

#### Allowed Shaders

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

:warning: Using a shader not in the list will result in an error when uploading your world.
