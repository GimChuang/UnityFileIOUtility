using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_FileIOUtility : MonoBehaviour {

    public string imageSavingPath = "";


	void Start () {

        StartCoroutine(E_TakeScreenshot());

    }
	
	void Update () {
		
	}

    IEnumerator E_TakeScreenshot()
    {
        yield return new WaitForEndOfFrame();

        Texture2D tex2d_screenshot = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

        tex2d_screenshot.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        tex2d_screenshot.Apply();

        Debug.Log("Photo taken!");

        FileIOUtility.SaveImage(tex2d_screenshot,
            imageSavingPath,
            FileIOUtility.GenerateFileName("MyScreenshot", 12, FileIOUtility.FileExtension.PNG),
            FileIOUtility.FileExtension.PNG);

    }
}
