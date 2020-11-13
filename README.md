# TM_Timer

## はじめに
トーストマスターズでの計時係の作業をサポートするためのツールです。  
ご自身のスピーチの練習や、例会にて使ってください。  
Windows10で動作します。

## ファイル構成　および　インストール
実行ファイル一つのみです。これをデスクトップ等、好きな場所においてください。  
設定ファイル等はありません。  
- Timer.exe --- TM Timer実行ファイル  

初回起動時に、「WindowsによってPCが保護されました。」という警告が出ますが、「詳細情報」をクリックして進んでください。  
これは、コード署名が無いためです。
新しいバージョンをインストールする場合は、上書きを行ってください。

## スクリーンショット
![Screenshot](https://github.com/kazamak/Timer/blob/master/screen_shot.png?raw=true)

## 操作方法

基本機能
|ボタン・エリア|機能|
|:---|:---|
|スピーチメニュードロップダウン|スピーチの種類を選択します。選択したスピーチの種類が記録エリアに記録されます。|
|開始（停止）ボタン|一般的なストップウォッチと同じ動作をします。中断、再開も可能です。|
|クリアボタン|現在のスピーチの計測を終了し、記録エリアにスピーチの時間を記録します。<br>時間表示は00:00に戻ります。|
|時間エリア|計測中は、経過時間が表示されます。|
|記録エリア|フォーマット：分分：秒秒、時間の最後に(--),(++)が付加されます。<br>  (--) スピーチ時間不足<br>  (++) スピーチ時間超過<br>スピーチ時間以内に終了した場合は、何も付加されません。|
|コメントタイムボタン|60秒のカウントダウンが始まります。|
|色表示エリア|時間の経過とともに、黒->緑->黄->赤->黒　と変化します。|
|終了ボタン|TM Timerが終了します。|

アドバンスド機能(LED表示灯を接続する場合に使用します）
|ボタン・エリア|機能|
|:---|:---|
|COM PORTドロップダウン|LED表示灯とUSBケーブル接続後、COMポート番号を選択します。|
|接続ボタン|COM PORT選択後、接続ボタンを押します。正常に接続されると、接続ボタンがグレーアウトされます。|

## 使用パターン
|組み合わせパターン|利用場所|
|:---|:---|
|TM_Timer単独|個人のスピーチの練習|
|TM_TimerとOBS Studioを組み合わせる|オンライン例会|
|TM_timerとLED表示灯を組み合わせる|オンサイト例会|
|TM_TimerとOBS StudioとLED表示灯を組み合わせる|ハイブリッド例会|
 
## 例会での使用方法(Zoomを使ったオンライン例会の場合）
OBS studioというソフトと仮想カメラソフトを使って、Zoomのビデオで指定します。OBS上でTimer.exeの画面をウィンドウキャプチャで取り込みます。
これにより、Zoomの画面共有を使用せずに、参加者にTM_Timer表示を見せることができます。  
詳しくは、OBS設定方法.pdfを参照ください。

- [OBS studio](https://obsproject.com/download)  
- [OBS virtual cam extension](https://obsproject.com/forum/resources/obs-virtualcam.949/)
- [OBS設定方法.pdf](https://github.com/kazamak/Timer/blob/master/OSB%E8%A8%AD%E5%AE%9A%E6%96%B9%E6%B3%95.pdf)

## 例会での使用方法（ハイブリッド例会の場合）
上記「Zoomを使ったオンライン例会の場合」に加え、表示灯を製作しPCにケーブル接続します。
- [LED表示灯ガイド](https://github.com/kazamak/Timer/blob/master/LED%E8%A1%A8%E7%A4%BA%E7%81%AF%E3%82%AC%E3%82%A4%E3%83%89.pdf)


## 開発環境
Windows 10, Visual studio 2019  

## その他
再配布等、ご自由に行ってください。

Email: kazamak(atmark)gmail.com
