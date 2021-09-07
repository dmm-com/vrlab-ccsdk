## CCSDKのダウンロード

CCSDK（Connect ChatカスタムワールドSDK）の導入方法は一般向けと上級者向けの２つの方法が用意されています。
それぞれ詳しく解説をしますので、選びたい方法をクリックして先へ進んでください。
<br>

- **[ワールドテンプレートを使うCCSDKの設定方法（一般向け）](08-tutorial-ccsdk-download.md#ワールドテンプレートを使うccsdkの設定方法_一般向け)**
- **[Gitを使うCCSDKの設定方法（上級者向け）](08-tutorial-ccsdk-download.md#gitを使うccsdkの設定方法_上級者向け)**
<br>

### ワールドテンプレートを使うCCSDKの設定方法_一般向け

ここでは、Connect ChatにワールドをアップロードするためのCCSDK設定済ワールドテンプレートを使った環境構築の方法を解説します。  
**一般向けの内容となりますので、気軽にワールドアップロードにチャレンジしてみましょう！**  
<br><br>
### 環境構築_ワールドテンプレート使用

Connect ChatにワールドをアップロードするにはCCSDK（Connect ChatカスタムワールドSDK）をUnityにインポートする必要がありますが、
専門的な作業をあらかじめすべて設定したワールドテンプレートを配布しています。  
はじめに、**下記URLからワールドテンプレートをダウンロードします。**  
<br>
**ワールドテンプレート : https://dmm-com.github.io/vrlab-ccsdk/manual/files/vrlab-ccsdk-template.zip**

ダウンロードが出来たらZipファイルを解凍してUnityに読み込みますが、ここで２つの方法があります。  
ワールテンプレートをもとに新しくワールドを作る時の方法と、既にあるワールドをワールドテンプレートにインポートする方法です。
それぞれ詳しく解説を行っていますので、先へ進んでみましょう。 
<br><br>
- **[テンプレートをもとに新しくワールドを作る方法](08-tutorial-ccsdk-download.md#テンプレートをもとに新しくワールドを作る方法)**
- **[既にあるワールドをテンプレートにインポートする方法](08-tutorial-ccsdk-download.md#既にあるワールドをテンプレートにインポートする方法)**
<br><br>

### テンプレートをもとに新しくワールドを作る方法  

ワールドテンプレートをダウンロードできたらZipファイルの解凍をしましょう。  
<br>
![template_t01](https://user-images.githubusercontent.com/68273442/124872413-32b0c700-e000-11eb-8114-7bc87183e9ff.png) 
<br><br>
普段UnityProjectを保存しているフォルダに、新しいワールドProject用のフォルダを作成します。ここでは01_SampleWorldという名前にしました。
新しいワールドProject用のフォルダ（01_SampleWorld）の中に先ほどの解凍したワールドテンプレートのAssettsフォルダがある階層の３つのフォルダ（Assets、Packages、ProjectSettings）をコピーします。
UnityHubを起動し、リストに追加から作成したワールドProject用のフォルダ（01_SampleWorld）を指定します。　
<br>
![template_t02](https://user-images.githubusercontent.com/68273442/124872673-84595180-e000-11eb-8384-61c1ccfaa7c8.png)  
<br><br>
UnityHubのリストにProjectが追加できたら、クリックして開きます。左上にConnect Chatのタブが追加されているとCCSDK導入の成功です。  
<br>
![template_t03](https://user-images.githubusercontent.com/68273442/124874283-81f7f700-e002-11eb-86bd-dfacf06cb5a2.png)
<br><br>
ワールドテンプレートからCCSDKが導入できたらいよいよワールドの作成です。  
<br>
**ワールドの一般的な作り方**を解説していますので、Unityの基礎的な解説が必要な方はこちらへ進んでください。
ワールドの作成方法を知っている方は、**共通設定とアップロード**へ進みましょう。  
<br>
- **[ワールドの一般的な作り方](09-tutorial-world-create.md#ワールドの一般的な作り方)**
- **[共通設定とアップロード](10-tutorial-world-upload.md#共通設定とアップロード)**
<br><br>

### 既にあるワールドをテンプレートにインポートする方法  

既に作ったワールドをCCSDK設定済ワールドテンプレートにインポートするには、まず既にあるワールドを開き、ProjectウインドウのAssetsフォルダ階層で右クリックをして
Export Packageを選択しUnityPackageとしてエクスポートを行います。  
<br>
![world_import_01](https://user-images.githubusercontent.com/68273442/125026863-589da080-e0c0-11eb-9eac-5be3ee43a604.png)
<br><br>
ポップアップが開くので、必要なものを選んでExportをクリックします。  
<br>
![world_import_02](https://user-images.githubusercontent.com/68273442/125075841-1a24d780-e0fa-11eb-8f1b-546c1d92b3ad.png)
<br><br>
次にワールドテンプレートを読み込んだUnityProjectに先ほどエクスポートしたワールドをインポートします。  
エクスポート同様にUnityProjectを開いてProjectウインドウのAssetsフォルダ階層で右クリックをしてImport Package>Custom Packageと選択します。  
<br>
![world_import_03](https://user-images.githubusercontent.com/68273442/125076003-4c363980-e0fa-11eb-9504-a26f05d8f039.png)
<br><br>
同様にポップアップが開くので、必要なものを選んでImportをクリックします。  
<br>
![world_import_04](https://user-images.githubusercontent.com/68273442/125076475-ebf3c780-e0fa-11eb-881d-c181124f1d08.png)
<br><br>
インポートが完了したら、ScenesフォルダからインポートしたワールドのSceneを選んで開きます。  
<br>
![world_import_05](https://user-images.githubusercontent.com/68273442/125076607-147bc180-e0fb-11eb-9cef-d75bfddcf788.png)
<br><br>
既にあるワールドをワールドテンプレートにインポートできました。  
<br>
![world_import_06](https://user-images.githubusercontent.com/68273442/125076771-47be5080-e0fb-11eb-9fe9-fc193dbf6c81.png)
<br><br>

次はいよいよワールドアップロードです。  
ワールド制作が万全の方は、**共通設定とアップロード**へ進みましょう。  
<br>
- **[共通設定とアップロード](10-tutorial-world-upload.md#共通設定とアップロード)**
<br><br><br>

### Gitを使うCCSDKの設定方法_上級者向け  

ここでは、Connect ChatにワールドをアップロードするためのGitを使った環境構築の方法を解説します。

**上級者向けの内容となりますので、はじめての方はワールドテンプレートを使った方法がおすすめです。**  
<br>

- **[ワールドテンプレートを使うCCSDKの設定方法（一般向け）](08-tutorial-ccsdk-download.md#ワールドテンプレートを使うccsdkの設定方法_一般向け)**
<br>

### 環境構築_Git使用

Connect ChatにワールドをアップロードするにはCCSDK（Connect ChatカスタムワールドSDK）をUnityにインポートして、ワールドのアップロードや管理を行います。



CCSDKをワールドテンプレートを使わずにインポートするにはGitが必要なため、下記のURLからGitをダウンロードしてインストールします。
またGitには複数の種類が存在しますが、ここでは下記のGitを使用した解説を行います。  
<br>
**Git : http://git-scm.com/**
<br><br>
![git_01](https://user-images.githubusercontent.com/68273442/125567800-96faf71a-9c07-4b84-ad36-e643e27c2326.png)
<br><br>
Gitがインストールできたら環境変数の設定をします。  
「システム環境変数の編集」はコントロールパネルにありますが、Windowsの場合デスクトップ左下にある検索ボックスからもアクセスが可能です。  
<br>
![git_02](https://user-images.githubusercontent.com/68273442/125567827-5427ab6b-2e44-4f64-84e6-04498224fbad.png)
<br><br>
環境変数を新規に設定するには、〇〇〇のユーザー環境変数の「新規」を選択し、変数名と変数値を入力します。  
特に変更を加えていなければ、下記のような入力内容になります。入力が終わったらPCを再起動しましょう。  
<br>
**変数名:Git**  
<br>
**変数値:C:\Program Files\Git\cmd;C:\Program Files\Git\mingw64\bin;C:\Program Files\Git\usr\bin**  
<br>
![git_03](https://user-images.githubusercontent.com/68273442/125567858-ac9b41fb-40b4-48f8-bdab-caca052c5979.png)
<br><br>
Unityを起動し、アップロードしたいワールドのProjectを開いてProjectウインドウのAssetsフォルダ階層で右クリックし、Show in Explorerを選びます。  
<br>
![git_04](https://user-images.githubusercontent.com/68273442/125567871-68a20d5c-3277-47a1-96c1-517a009ef826.png)
<br><br>
ポップアップでエクスプローラーが開くので、Packagesフォルダの中のmanifest.jsonを探してメモ帳アプリケーションなどで開きます。  
そして２行名から始まる"dependencies"：｛　の次の行に、下記テキストを入力して上書き保存をしましょう。  
<br>
**"com.dmm.vrlab.ccsdk": "https://github.com/dmm-com/vrlab-ccsdk.git#v1.1.0",**
<br><br>
**また、上記テキストのうちv1.1.0となっている箇所はバージョン情報であり、Connect Chatのバージョンアップデートによって変更となります。
最新版の確認は必要に応じて、[ドキュメント](../Japanese/03-setting-up-the-sdk.md#SDKのセットアップ)にて行ってください。**
<br><br>
![git_05](https://user-images.githubusercontent.com/68273442/125567931-49d607ba-1577-475a-9401-e1c41023de23.png)
<br><br>
Unityに戻ると自動でCCSDKのインポートが始まります。  
Connect Chatのタブが生成されるとインポートの成功です。  
<br>
![git_06](https://user-images.githubusercontent.com/68273442/125567947-959b03f4-88fd-4b7e-a941-8a4f454a3af4.png)
<br><br>
GitからCCSDKが導入できたらいよいよワールドの制作です。  
<br>
**ワールドの一般的な作り方**を解説していますので、Unityの基礎的な解説が必要な方はこちらへ進んでください。
ワールドの作成方法を知っている方や既にワールドの準備が出来ている方は、**共通設定とアップロード**へ進みましょう。  

また、ConnectChatでワールド制作する上での事前準備として
**UnityのColorSpaceをLinearに変更する必要があります。詳しい設定方法はワールドの一般的な作り方の冒頭で解説しています。**
<br>
- **[ワールドの一般的な作り方](09-tutorial-world-create.md#ワールドの一般的な作り方)**
- **[共通設定とアップロード](10-tutorial-world-upload.md#共通設定とアップロード)**
<br>
