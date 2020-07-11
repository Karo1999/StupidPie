﻿using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    public GameObject hudCanvas;
    public SettleUI settleUI;

    private TimerUI m_TimerUI;
    private ScoreUI m_ScoreUI;

    public TimerUI TimerUI { get { return m_TimerUI; } }

    private void Awake()
    {
        m_TimerUI = hudCanvas.GetComponentInChildren<TimerUI>();
        m_ScoreUI = hudCanvas.GetComponentInChildren<ScoreUI>();
    }

    public void ToggleHUDCanvas(bool active)
    {
        hudCanvas.SetActive(active);
    }

    public void ToggleSettleCanvas(bool active)
    {
        settleUI.gameObject.SetActive(active);
    }

    public void SetHUDMessage(ref TextMeshProUGUI timerText, ref TextMeshProUGUI scoreText)
    {
        timerText.text = m_TimerUI.minuteAndSecondsText.text + m_TimerUI.milliSecondsText.text;
        scoreText.text = m_ScoreUI.scoreText.text;
    }
}
