# SDK Components

## CC_World

This component is required on each world.

![CC_World](../images/cc-world.png)

**Reference Camera:** The camera used to configure the post-processing effects of your world.
Assign to this field the camera where you have added the _Post-process Volume_ and
the _Post-process Layer_ components.

**Respawn Height:** Avatars may fall below the ground plane if they venture too far in the world.
Once they reach the height specified they will respawn automatically.

**Spawn Points:** The spawn points used to place the avatar in the world. The actual spawn point is
randomly chosen.

## CC_Grabbable

If you add this component to object you want people to be able to pick-up and drop.