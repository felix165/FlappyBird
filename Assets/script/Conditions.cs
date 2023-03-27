using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Conditions : MonoBehaviour
{

    public GameObject score;
    public GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
        gameover.SetActive(false);
    }
    //time scale == 0 jika menyentuh object dengan tag "Lose" (ground and pipes)
    void OnTriggerEnter2D (Collider2D obj)
    {

        if (obj.gameObject.tag == "Lose" )
        {
            GameObject.Find("hit").GetComponent<AudioSource>().Play();
            gameover.SetActive(true);
            Time.timeScale = 0;

        }
        //ketika melewati box score (melewati rintangan), score akan bertambah
        if(obj.gameObject.tag == "addScore")
        {
            GameObject.Find("point").GetComponent<AudioSource>().Play();

            score.GetComponent<scoring>().Score++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
