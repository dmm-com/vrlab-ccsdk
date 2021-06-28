# SDKコンポーネント

## CC_World

ワールドには必ずこのコンポーネントを設定する必要があります。

![CC_World](../images/cc-world.png)

**Reference Camera:** ワールドのポストプロセス設定に使用するカメラです。
_Post-process Volume_と_Post-process Layer_コンポーネントを追加したカメラを設定します。

**Respawn Height:** アバターが地面より下に落ちた時リスポーンする高さを設定します。

**Spawn Points:** アバターをワールド内にスポーンさせる位置を設定します。複数設定した場合は毎回ランダムに選択されます。

## CC_Grabbable

このコンポーネントを追加したオブジェクトは持つことができるようになります。
