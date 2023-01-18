using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   // [SerializeField] TextMeshProUGUI timerText;
    public Text timerDisplay;
    public float timer;
    public int minutes;
    public int seconds;
    //DateTime timer = DateTime.Now;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        minutes = (int) timer / 60;
        seconds = (int) timer % 60;

        //Debug.Log("Minutes:" + minutes);
        //Debug.Log("Seconds:" + seconds);
        timerDisplay.text = minutes + ":" + seconds;
    }
}
