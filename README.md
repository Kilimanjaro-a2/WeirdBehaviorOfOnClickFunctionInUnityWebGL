# WeirdBehaviorOfOnClickFunctionInUnityWebGL

A demonstration that the OnClick() function behaves weirdly in a WebGL build with Unity.


## The demo page

https://kilimanjaro-a2.github.io/WeirdBehaviorOfOnClickFunctionInUnityWebGL/

This app is written in Japanese, but you can probably understand what happens even if you are not a Japanese speaker.

## Description

When you want to call a function written in .jslib in WebGL build with Unity,

it will work correctly if you use PointerDown () of EventTrigger component.

However, when OnClick () of the Button component is used, the first click does not respond.

This project is a demo of that weird behaviour.

## Supplement

I defined a method called OnButtonClicked() a file called JslibCaller.cs and this calls CaptureClick () on .jslib.


If this is called from OnClick () of the Button component,

OnButtonClicked () is called normally, but the FileImporterCaptureClick () called in it is not called.

And for some reason it is called with a second click.

I don't know the cause.

If anyone can explain this strange behavior, please let me know.
