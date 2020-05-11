using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float gameTimer;
    public bool gamePaused = false;

    void Update()
    {
        if (!gamePaused)
        {
            gameTimer += Time.deltaTime;
        }
    }
}
// https://forum.unity.com/threads/how-do-i-pause-a-timer.165939/