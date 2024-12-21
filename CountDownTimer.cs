using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CountDownTimer : MonoBehaviour
{   /// <summary>
    /// 
    /// </summary>
    private float m_startTime;
    public int TotalSeconds { get; private set; }

    public void ResetTimer(int seconds)
    {


        m_startTime = Time.time;
        TotalSeconds = seconds;
    }

   
    public float RemainingSeconds => TotalSeconds - (Time.time - m_startTime);

    public int RemainingSecondAsInt => (int)RemainingSeconds;




}
