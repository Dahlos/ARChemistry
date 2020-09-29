using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneMenuManager : MonoBehaviour
{   
    [Header("Loading Screen")]
    public GameObject loadingScreen;
    public Slider sliderLoadingScreen;
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnClickStartApp(int indexStartScene)
    {
        // SceneManager.LoadScene(indexStartScene);
        StartCoroutine("LoadYourAsyncScene", indexStartScene);
    }

    IEnumerator LoadYourAsyncScene(int indexStartScene)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(indexStartScene);
        loadingScreen.SetActive(true);
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / .9f);
            sliderLoadingScreen.value = progress;
            yield return null;
        }
    }

    public void OnClickHowItWorks()
    {
        // SHOW PANEL HOW IT WORKS

    }

    public void OnClickExitApp()
    {
        Application.Quit();
    }


}
