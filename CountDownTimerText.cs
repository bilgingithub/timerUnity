using UnityEngine;
using UnityEngine.UI;

public class CountDownTimerText : MonoBehaviour
{

    private Text m_textTimer;
    private CountDownTimer m_countDownTimer;

    private static string getMessage(int seconds)
    {
        return seconds <= 0 ? "Finished" : $"Remaining Seconds : {seconds}";
        
    }

    private void Awake()
    {
        m_textTimer = GetComponent<Text>();
        m_countDownTimer= GetComponent<CountDownTimer>();
    }

    private void startTimer() => m_countDownTimer.ResetTimer(10);
    private void Update() => m_textTimer.text = getMessage(m_countDownTimer.RemainingSecondAsInt);
}
