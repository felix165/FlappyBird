using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameOver : MonoBehaviour
{
    public GameObject timer;
    public float timeLeft;

    
    
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //ketika gameover, dengan menekan space bar. permainan akan dimulai ulang

        if (Input.GetKeyDown("space"))
        {
            Time.timeScale = 1;
            timer.GetComponent<timer>().timeLeft = timeLeft;
            SceneManager.LoadScene(1);
            
        }

        
        


    }
}
