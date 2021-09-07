## ワールドの一般的な作り方

ここではワールドの一般的な作り方を解説します。まず、BlenderやMayaといった3DCGソフトで3Dモデルをモデリングをするか、
アセット販売サイトなどで3Dモデルを購入するなどして、ワールドを作るための3Dモデルを用意します。  
<br>
![worldcreate_01](https://user-images.githubusercontent.com/68273442/124876145-a94fc380-e004-11eb-907b-04fb774f6220.png)
<br><br>

### ConnectChatのための事前準備
ConnectChat用の設定としてUnityのカラースペースの設定を行っておきましょう。  
Edit→Project Settingsと進んで、Playerから
**ColorSpaceをLinearに設定しましょう。**
事前の設定はこれだけで、テンプレートを使用する場合は設定済なので新しい設定は不要です。  
<br>
![worldcreate_00_01](../images/worldcreate_00_01.png)
<br><br>


### オブジェクトのインポートと配置

3DモデルはFBXなどの形式でエクスポートし、UnityProjectのAssetsフォルダ配下に新しくオブジェクト管理用のフォルダを作成します。ここではMeshフォルダを作成しました。  
そしてエクスポートした3Dモデルをドラッグアンドドロップするなどの方法でUnity内にインポートをします。インポートができたら必要なオブジェクトをHierarchyに
ドラッグアンドドロップして、シーンに配置し、位置の調整などを行います。 
マテリアルやテクスチャの設定、ライトマップ用UVの生成などが必要な場合は同様に設定を行いましょう。  
<br>
![worldcreate_02](https://user-images.githubusercontent.com/68273442/124876215-b967a300-e004-11eb-872b-3bd03f62e7fb.png)
<br><br>
マテリアルの生成方法はいくつか方法がありますが、ここでは3DCGソフトであらかじめ設定したマテリアルを取り出す方法を解説します。
インポートしたオブジェクトを１つ選択してInspectorのMaterialsタブを開き、下記のように設定してApplyをクリックしましょう。  
<br>
**Location : Use External Materials(Legacy)**  
**Naming : From Model's Material**  
<br>
![worldcreate_02_02](https://user-images.githubusercontent.com/68273442/125438527-3eec7302-8743-41c2-a85d-f986312cebf1.png)
<br><br>
自動で同階層にMaterialsフォルダが生成され、このフォルダの中にマテリアルが作成されました。この方法でマテリアルを作成する事でマテリアル名などの再設定が不要となります。  
また、複数のオブジェクトからマテリアルを取り出す場合は続いて、下記のような手順で操作をします。  
<br>
**①右上のSelect Presetアイコンをクリックします。  
②ポップアップするSelect PresetウインドウからSave current to…をクリックし、プリセットを保存します。  
③マテリアルを取り出したいオブジェクトをすべて選択します。  
④Select Presetウインドウから先ほど保存したプリセット「FBXImporter.preset」を選択します。  
⑤Applyをクリックします。これで複数オブジェクトからマテリアルが作成できました。**
<br>

![worldcreate_02_03](https://user-images.githubusercontent.com/68273442/125440265-d63eea2b-5c86-4441-8fba-519c472237aa.png)
<br><br>
マテリアルが作成できたら、テクスチャを割り当てます。テクスチャ画像をインポートしたらマテリアルのInspectorの該当するMapにテクスチャを割り当てます。
ここではPBR（物理ベースレンダリング）でテクスチャを作成していましたのでAlbedo/MetallicSmoothness/NormalMapの３枚の画像を割り当てました。
<br>

![worldcreate_02_04](https://user-images.githubusercontent.com/68273442/125441498-23e6c386-7722-41a0-a4be-76e99fc265a9.png)
<br><br>
最後に、後にライティングをした際にライトベイクを行うオブジェクトにはLightmapUVを作成しておきましょう。必要なオブジェクトを選択してInspectorのModelタブから
Generate Lightmap UVsにチェックを入れてApplyをクリックしましょう。これで自動でLightmapUVが生成されます。
<br>

![worldcreate_02_05](https://user-images.githubusercontent.com/68273442/125442203-1071380a-4373-4bbe-b53e-34b56dda0b3b.png)
<br><br>
### コライダーの設定

次に床や壁、障害物などにコライダーの設定を行います。コライダーの設定はオブジェクトのInspectorからAdd Componentをクリック、Box ColliderやMesh Colliderを選択して追加します。  
これによってキャラクターがオブジェクトの上を移動したり、移動範囲を制限する壁を作ったりできます。  
<br>
![worldcreate_03](https://user-images.githubusercontent.com/68273442/124889868-757b9a80-e012-11eb-9daf-7df605aaf5a5.png)
<br><br>
### Skybox設定とライティング

次はSkyboxの設定をしましょう。Skyboxはワールドの環境光や背景を扱うことが出来ます。HDRIの画像を用意してインポートし、HDRI画像のInspectorからTexture ShapeをCubeとします。  
<br>
![worldcreate_04_01](https://user-images.githubusercontent.com/68273442/124891422-eff8ea00-e013-11eb-85b4-52ef17e61417.png)
<br><br>
右クリックで新しくマテリアルを作成し、マテリアルのInspectorのShaderをSkybox>Cubemapに変更し、Cubemap(HDR)の項目に、先ほど用意したHDRI画像を割り当ててみましょう。
<br>
![worldcreate_04_02](https://user-images.githubusercontent.com/68273442/124892467-df953f00-e014-11eb-9a44-525cff8eb982.png)
<br><br>
Lithingウインドウ（Window>Rendering>Lighting Settings）のSkybox Materialに先ほど作成したSkyboxのマテリアルを割り当てます。これでSkyboxの設定が完了です。  
必要に応じてIntensity Multiplierなどの設定で環境光の強さを設定しましょう。
<br>
![worldcreate_04_03](https://user-images.githubusercontent.com/68273442/124896504-731c3f00-e018-11eb-9e70-8a7079c79001.png)
<br><br>
次にライトの設定をしましょう。今回は既にあるDirectionalLightを使用しますが、PointLightなど他のライトを自由に配置して世界観を作る事が可能です。  
ここではColorを青味のある色に、Intensityを少し下げ、ShadowのStrengthを半分にしました。
<br>
![worldcreate_05_01](https://user-images.githubusercontent.com/68273442/124898453-2c2f4900-e01a-11eb-8014-47bd5ce64cac.png)
<br><br>
ライトの設定が終わったら必要に応じてライトベイクを行う事によって、計算負荷を減らしワールドでより快適に遊ぶことができるようになります。  
**Bakeを行う場合は配置したライトのModeをBakedに設定し、また、Hierarchyからワールド内で動かないオブジェクトをすべて選択し、InspactorのStaticにチェックを入れます。**  
そしてLightingウインドウのLightmapping Settingsの設定を行い、Generate Lightingをクリックする
ことでライトベイクを行う事ができます。
<br><br>
![worldcreate_05_02](https://user-images.githubusercontent.com/68273442/124899191-d7400280-e01a-11eb-8527-c8731d115ae2.png)
<br><br>
### ポストエフェクト

必要に応じてポストエフェクトを追加してみましょう。ポストエフェクトを追加することでワールドに様々な効果を与える事ができます。ただし、計算負荷も増えてしまうため計画的に使用するようにしましょう。  
ポストエフェクトの追加はMainCameraのInspectorからAdd Componentをクリック、Post-process LayerとPost-process Volumeを追加します。  
Post-process Layerの設定はLayerをDefaultに設定しましょう。  
Post-process VolumeはIs Globalにチェック、Profile>Newと進み、Add effectから追加したいエフェクトを選びます。
ここでは例としてColor Gradingを追加し、Saturation（彩度）とContrast（コントラスト）を調整してみました。  
<br>
![worldcreate_06](https://user-images.githubusercontent.com/68273442/124905267-d7db9780-e020-11eb-874a-1eb5e9c08ed0.png)
<br><br>
以上で一般的なワールド制作の手順となります。  
あなただけの素敵なワールド制作にチャレンジできましたか？  
<br>
次はConnectChatでの**共通設定とアップロード**を解説しますので先へ進んでみましょう。  
<br>
- **[共通設定とアップロード](10-tutorial-world-upload.md#共通設定とアップロード)**
