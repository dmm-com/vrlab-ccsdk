## 共通設定とアップロード
ワールドが準備できたらアップロード前の共通設定を行って、ワールドをアップロードしましょう。  
<br>

### ワールドアップロード前の共通設定

Connect Chatにワールドをアップロードするには２つの約束があります。  
<br>
- **[SpawnPoint（スタート地点）の設定](10-tutorial-world-upload.md#spawnpointの設定)**
- **[非対応のコンポーネントの削除](10-tutorial-world-upload.md#非対応のコンポーネントの削除)**
<br>

それぞれ解説をしていきます。
<br><br>
### SpawnPointの設定

SpawnPoint（スタート地点）を設定することで、プレイヤーの初期出現位置の設定を行います。

Hierarchyで右クリックから、Create Emptyを選択し、空のGame Objectを作成します。このGame ObjectのInspectorからAdd Componentをクリック、CC_Worldを追加しましょう。
またこのGame Objectはスタート地点になるため、任意の場所に配置を行いましょう。
<br><br>
![common_01](https://user-images.githubusercontent.com/68273442/124908004-ccd63680-e023-11eb-9937-b3fb870438c9.png)
<br><br>

CC_Worldの設定は以下のように行います。  
<br>

**ReferenceCamera　：　Main Camera**　（HierarchyからMain Cameraをドラッグアンドドロップすると、ポストエフェクトが有効になる）  
**Respawn Height　：　-1000**　（デフォルト値は-1000、Heightが-1000の値になった時にプレイヤーがRespawnする）　　

**Spawn points**  
**Size　：　1**　（設定した数だけSpawnPointを設定でき、これらはワールド入室時ランダムで選ばれる）  
**Element 0　：　GameObject**　（Hierarchyから参照GameObjectをドラッグアンドドロップすると、この位置がSpawn位置になる）  
<br>
Spawn pointsのElementはSizeの数を2以上にすると複数設定が可能で、空のGameObjectを新しく追加してSpawnPointとして設定することが出来ます。
また、GameObjectは必要に応じてリネームを行っても構いません。  
<br>
![common_02](https://user-images.githubusercontent.com/68273442/124909689-b9c46600-e025-11eb-987e-3dbb89adc289.png)
<br><br>
以上で、SpawnPointの設定は完了です。    
<br>
### 非対応のコンポーネントの削除

Connect Chatでは非対応のコンポーネントが付属しているとアップロードを行う事ができません。  
デフォルトではMainCameraのInspectorに付属しているAudio Listenerが非対応コンポーネントですので、Remove Componentで削除しましょう。
他にも追加している場合は削除を検討する必要がありますが、デフォルトではAudio Listenerのみです。  
<br>
![common_03](https://user-images.githubusercontent.com/68273442/124911517-cb0e7200-e027-11eb-804f-df1105e5c2bf.png)
<br><br>
以上がConnect Chatにワールドをアップロードする際の共通設定です。  
それでは、いよいよアップロードをしてみましょう！  
<br>
- **[ワールドアップロードと公開_パブリッシュ](10-tutorial-world-upload.md#ワールドアップロードと公開_パブリッシュ)**
<br><br>

### ワールドアップロードと公開_パブリッシュ

ワールドの準備とアップロード前の共通設定が済んだら、上部にあるConnect ChatタブからControl Panelを開きます。  
<br>
![upload_01](https://user-images.githubusercontent.com/68273442/124913619-4e30c780-e02a-11eb-942b-7ea465a6b6dd.png)
<br><br>
ログインボタンがあるのでDMM VR Connectにログインします。  
DMM VR Connectにアカウント登録がまだの方は下記URLのDMM VR Connectのページからアカウント登録を行います。
<br><br>
**DMM VR Connect : https://connect.vrlab.dmm.com/**
<br><br>
![upload_02](https://user-images.githubusercontent.com/68273442/124914164-00688f00-e02b-11eb-804b-8fe846c14689.png)
<br><br>
ブラウザが開きますので、そのまま既定のログイン方法でログインをしましょう。  
<br>
![upload_03](https://user-images.githubusercontent.com/68273442/124914730-a916ee80-e02b-11eb-9c0e-c9eed1b0b996.png)
<br><br>
ログインが出来たらコントロールパネルが開きます。最初は何も表示がありませんがワールドをアップロードすると下記画像のようにアップロードしたワールドが一覧表示されます。  
ここでは、新しくワールドを追加するので、左上の十字のCREATE WORLDアイコンをクリックして新しいスロットを作成しましょう。  
<br>
![upload_04](https://user-images.githubusercontent.com/68273442/125073380-cf559080-e0f6-11eb-81ca-6d9867185449.png)
<br><br>
Connect ChatイメージキャラクターGinoのサムネイルが表示された新しいスロットが追加されました。  
次に、右上のEditアイコンをクリックして編集モードに入ります。編集モードでTitle（ワールド名）やDecription（説明）を記入しましょう。  
**この時の注意点として、Titleはアルファベットのみをサポートしますが入力後Enterを押すことを忘れないようにしましょう。**  
<br>
![upload_05](https://user-images.githubusercontent.com/68273442/124915869-fc3d7100-e02c-11eb-96a8-b6341dac1273.png)
<br><br>
このままサムネイルも作成しましょう。スクリーンショットなどで正方形の画像を作成したら、サムネイルとして扱えるサイズにします。  
Photoshopなどの画像処理ソフトを使ってリサイズする場合は256×256pxのPNG形式などで書き出してUnityにインポートを行います。  
Unityでリサイズをする場合はPNG形式などで保存してインポートを行い、Inspectorからサイズ設定などの変更を加えます。設定は下記の通りです。  
<br>
**Advanced  
Read/Write Enabled : チェック  
Max size : 256  
Format : RGB 24 Bit**  
<br>
リサイズ設定をしたら、Connect Chatコントロールパネルのサムネイル窓へ画像をドラッグアンドドロップして、画像が更新されたらEditアイコンをクリックして編集モードを終了しましょう。  
<br>
![upload_06](https://user-images.githubusercontent.com/68273442/124921686-9bfdfd80-e033-11eb-88a8-5ca3d34fca47.png)
<br><br>
次はアップロードです。アップロードはBuild & Uploadアイコンで行います。この時点でサーバーにはアップロードされますが、ユーザーに公開にはなっていないので安心してアップロードしましょう。  
また、アップロードが完了しUploadedというポップアップが出現すると成功ですが、出現しない場合consoleのエラーメッセージを確認してください。
主に、非対応コンポーネントの削除や非表示を忘れている場合にアップロードエラーとなります。  
<br>
![upload_07](https://user-images.githubusercontent.com/68273442/124922757-ca300d00-e034-11eb-8f70-8555a95b8520.png)
<br><br>
アップロードが完了したら、ワールド選択画面から選べるようになります。  
この時はまだあなたのみがこのワールドをConnect Chat上でルームとして設立することが出来る状態です。
<br><br>
最後に、任意でワールドをPublicにする事ができます。Publicにすることであなたを含めたConnect Chatユーザー全員があなたのワールドをワールド選択画面で選択し、ルームを設立することができるようになります。  
Publicは編集モードでチェックを入れるのでEditアイコンをクリックして編集モードに入ったら、
Publicのチェックボックスにチェックを入れて、Editアイコンを再度クリックして編集モードを終了してください。  
<br>
![upload_09](https://user-images.githubusercontent.com/68273442/124924696-ac63a780-e036-11eb-92de-5cbcd3348cfb.png)
<br><br>
これであなたのワールドがPublicとなり、世界中に公開されました！おめでとうございます！！  
SNSなどで多くの人にマイワールドへの訪問を呼び掛けてみましょう！  
<br>
あなたのたくさんのワールドアップロードとConnect Chatの活用を応援しています。  
<br><br>

**ワールドをより魅力的なものにする追加機能もチェックしてみましょう。**  
<br>
- **[追加機能](11-tutorial-additional-features.md#追加機能)**
