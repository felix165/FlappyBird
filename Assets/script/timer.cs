using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour
{
    public float timeLeft;
    public  Text timerText;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //Batasan waktu bermain
        //ketika waktu habis, maka permainan akan berakhir
        timeLeft -= Time.deltaTime;
        timerText.text = (timeLeft).ToString("0");

        if(timeLeft < 0) {
            timerText.text = "Times out";
            Time.timeScale = 0;
            gameover.SetActive(true);
            
        }

        
    }
}
