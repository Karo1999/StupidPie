﻿using UnityEngine;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class OptionUI : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UIManager.Instance.SetHUDMessage(ref timerText, ref scoreText);
        //scoreText.text = Publisher.Instance.Observers[0].PlayerInfo.scoreable.scoreData.newScore.ToString();
    }

    public void Resume()
    {
        SceneController.Instance.UnPause(true);
        SceneController.Instance.PauseOff.Play();
    }

    public void Restage()
    {
        SceneController.Instance.UnPause(false);
        SceneController.Instance.Restage();
    }

    public void Regame()
    {
        SceneController.Instance.UnPause(false);
        SceneController.Instance.Regame();
    }

    public void Setting()
    {
        Debug.Log("Setting");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}