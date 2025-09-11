using UnityEngine;
using TMPro; // Required for TextMeshPro

public class TimerCountUpTMP : MonoBehaviour
{
    public TMP_Text timerText; // Drag your TMP Text UI element here

    private float currentTime = 0f;

    void Update()
    {
        currentTime += Time.deltaTime;
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

