using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timee = 90f;
    public TextMeshProUGUI timerText;
    public void Update()
    {
        timee -= Time.deltaTime;
        timerText.text = "Time : " + timee.ToString();
        if (timee <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
