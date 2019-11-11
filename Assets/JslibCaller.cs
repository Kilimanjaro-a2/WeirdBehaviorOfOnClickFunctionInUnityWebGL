using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class JslibCaller : MonoBehaviour {
    [DllImport("__Internal")]
    private static extern void FileImporterCaptureClick();
    [SerializeField]
    private Text clickInformationText;
    [SerializeField]
    private Text fileInformationText;
    private int clickCount = 0;

    public void OnButtonClicked()
    {
        clickInformationText.text = ++clickCount + "回ボタンがクリックされました！";
        FileImporterCaptureClick();
    }

    public void FileSelected(string url)
    {
        fileInformationText.text = url + "が読み込まれました";
    }
}