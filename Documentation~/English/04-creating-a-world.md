# Creating Your First World

Creating a new world is a simple process:

1. Create and setup a scene containing your world content.
2. Log into your [VR Connect](https://connect.vrlab.dmm.com) account.
3. Add a new world to your list.
4. Upload the scene.
5. Publish your world.

## Step 1 - Create and Setup the Scene

Create a new scene and populate it with the content of your world.

![Create and populate your scene.](../images/scene-create.png)

When you are done, add an empty _GameObject_ and attach the _CC World_ component to it.

![Add the CC World component.](../images/scene-add-cc-world.png)

Add spawn points to the scene by creating empty _GameObjects_:

![Create a spawn point.](../images/scene-create-spawn-point.png)

and add them to the _CC World_'s spawn point list.

![Add the spawn point to CC World.](../images/scene-add-spawn-point.png)

:warning:  Not all Unity components or shaders are usable in the scene: see [here](05-supported-components.md#allowed-components) for the list of allowed components, and [here](05-supported-components.md#allowed-shaders) for the list of allowed shaders.

## Step 2 - Log into VR Connect

1. Open the control panel using the _Connect Chat_ menu.

    ![Open the Control Panel](../images/control-panel-open.png)

2. The first time you open the control panel, the terms of services will be shown.
   Using the control panel requires accepting the terms of service.

    ![ToS](../images/tos.png)

3. Once the control panel window appears, press the _Login_ button to login into your [VR Connect](https://connect.vrlab.dmm.com) account.

    ![Login into Connect](../images/control-panel-login.png)

4. Press the _Confirm_ button in the browser window that opened and return to Unity.

    ![Device Confirmation](../images/device-confirmation.png)

5. Once logged in the control panel will show the list of world you have uploaded.

    ![Empty World List](../images/empty-world-list.png)

In addition to the world list, the control panel windows show the user information and
has a few useful controls:

![Control Panel Anatomy](../images/control-panel-anatomy.png)

## Step 3 - Adding a New World

Click the `+` button to create a new world; the world list will update and a new world should be added to your list:

![World Entry](../images/world-entry.png)

**ID:** The internal id of the world.

**Title:** The name of the world and what is shown in the world selections screen. Titles must be composed of a maximum of 16 letters or digits.

**Description:** One or two short sentences describing your world.

**Tags:** A list of tags describing your world. A maximum of 8 tags are allowed, each tag composed of a maximum of 16 letters or digits.

**Public:** Shows if the world is usable by everyone or only by you (you will still be able to invite people into one instance).

The image on the right is the world's thumbnail: a 256x256 texture that will be shown together with the world title on the world selection screen.

On the far right there are four icons:

![](../images/world-edit-icon.png) **Edit:** Toggles the edit mode for the world details. 

![](../images/world-publish-icon.png) **Publish:** Publishes the world and make it available in the World Selection window. 

![](../images/world-upload-icon.png) **Build & Upload:** Builds the world asset bundle using the current active scene and uploads it.

![](../images/world-delete-icon.png) **Delete:** Deletes the world (this operation cannot be undone).

### Editing your World Details

Click the _Edit_ button and toggle the _edit mode_ for your world.

You can now edit the title and description of your world, change its thumbnail, and toggle it's visibility flag.

![Editing the world details.](../images/world-edit.png)

Custom thumbnails must be 256 x 256 pixels and be imported with the following settings:

![Thumbnail import settings.](../images/world-thumbnail-import-settings.png)

## Step 4 - Uploading

To building and uploading your world just click on the build button: a dialog will appear once the upload is completed.
If anything wrong happens (for example, the scene contains components that are not allowed), check the console for error messages.

## Step 5 - Publish your World

Once the details of your world are in order and the scene has been uploaded press the publish button to make your world usable in Connect Chat.
