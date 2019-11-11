# WeirdBehaviorOfOnClickFunctionInUnityWebGL
UnityのWebGLビルドでOnClick()が変な挙動をするデモ


## Demo page
実際に動作するページ

https://kilimanjaro-a2.github.io/WeirdBehaviorOfOnClickFunctionInUnityWebGL/


## What is this?

UnityのWebGLビルドで、.jslibに記述した関数を呼び出したいとき、

EventTriggerコンポーネントのPointerDown()を使用した場合は正常に動作するが、

ButtonコンポーネントのOnClick()を使用した場合、1回目のクリックが反応しないことを確かめるためのデモ。


## Memo

JslibCaller.csというファイルに、OnButtonClicked()というメソッドを定義し、

.jslib上のFileImporterCaptureClick()を呼び出すよう記述した。

これをButtonコンポーネントのOnClick()から呼び出すと、

OnButtonClicked()は正常に呼ばれるが、その中で呼び出しているFileImporterCaptureClick()は呼び出されず、

2回目のクリックで遅れて呼ばれるという謎の挙動をする。


原因は不明。


## Reference

WebGLからファイルダイアログを呼び出す方法については、以下の記事を参考にさせていただきました。


https://qiita.com/torikasyu/items/bc45f51f855f332a64f7


https://qiita.com/mechamogera/items/89d4555b202af96810af
