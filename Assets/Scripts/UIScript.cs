using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "MenuScene" || scene.name == "MainScene")
            {
                 Application.Quit();
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public void About()
    {
        Application.OpenURL("http://pinkdecoder.com/about/");
    }


    public void MenuScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ReportScene()
    {
        SceneManager.LoadScene(2);
    }

    public void AwarenessScene()
    {
        SceneManager.LoadScene(6);
    }

    public void BluetoothScene()
    {
        SceneManager.LoadScene(5);
    }

    public void BookScene()
    {
        SceneManager.LoadScene(4);
    }

    public void MainScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Setting()
    {
        SceneManager.LoadScene(3);
    }

    public void launchAR()
    {
        SceneManager.LoadScene(7);
    }

    public void Riskfactor()
    {
        Application.OpenURL("http://pinkdecoder.com/riskfactor/");
    }

    public void Sbe()
    {
        Application.OpenURL("http://pinkdecoder.com/sbe/");
    }

    public void JoinCommunity()
    {
        Application.OpenURL("https://www.facebook.com/groups/1865145147094353/");
    }


    public void BookADoctor()
    {
        Application.OpenURL("http://pinkdecoder.com/book/");
    }

    public void ToastMessage(string message)
    {
        if (Application.platform == RuntimePlatform.Android) { 
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

            if (unityActivity != null)
            {
                AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");
                unityActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
                {
                    AndroidJavaObject toastObject = toastClass.CallStatic<AndroidJavaObject>("makeText", unityActivity, message, 0);
                    toastObject.Call("show");
                }));
            }
        }
    }

    public void Ordernow()
    {
        Application.OpenURL("http://pinkdecoder.com/");
    }

    public void mammogram()
    {
        Application.OpenURL("https://www.google.com/maps/search/mammogram+near+me/");
    
    }

    public void PrintNow(GameObject panel)
    {
        Application.OpenURL("http://pinkdecoder.com/print/scan.jpg");
        panel.SetActive(false);

    }

    public void IhavePrintedIt(GameObject panel)
    {
        panel.SetActive(false);

    }
}
