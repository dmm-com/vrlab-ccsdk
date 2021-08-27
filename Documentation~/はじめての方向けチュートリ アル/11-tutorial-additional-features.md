## 追加機能

### グラバブル機能

Connect Chatではオブジェクトにコンポーネントを追加することで、ワールド内で物を持って遊ぶ事が可能です。
ここではコンポーネントの追加手順を解説します。  
<br>
持ちたいオブジェクトの、InspectorからAdd Componentをクリックして、任意のコライダーを追加します。  
ここではBox Colliderを追加しました。  
<br>
![grabbable_01](https://user-images.githubusercontent.com/68273442/125577520-9a11bc55-b4ef-4d4e-b10a-9aa426305d1c.png)
<br><br>
任意のコライダーを追加できたら同様にAdd ComponentからCC_GrabbableとRigidbodyを追加します。  
そして３つのコンポーネントの設定を下記の通り設定します。  
<br>
**Box Collider  
Is Trigger : チェックを入れる**  
<br>
**CC_Grabbable  
設定変更なし**  
<br>
**Rigidbody  
Use Gravity : チェックを外す  
Is Kinematic : チェックを入れる**  
<br><br>
![grabbable_02](https://user-images.githubusercontent.com/68273442/125577534-83ae615c-a099-4fd8-99be-03f9da6ad2c5.png)
<br><br>
そして、通常通りワールドをアップロードするとグラバブル設定したオブジェクトに近づいた際に緑色にハイライトし、
VR/デスクトップともにオブジェクトを持つことが可能になります。
