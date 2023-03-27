using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float berat, tinggi_loncatan;
    Rigidbody2D bird;


    // Start is called before the first frame update
    void Start()
    {
        bird = this.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //ketika time scale == 0 , program tidak dijalankan
        //time scale ==0 ketika game over
        if (Time.timeScale != 0)
        {
            //loncat setiap tekan space bar
            if (Input.GetKeyDown("space"))
            {
                GameObject.Find("wing").GetComponent<AudioSource>().Play();
                bird.velocity = new Vector2(bird.velocity.x, tinggi_loncatan);

            }
            //jatuh terus jika tidak menekan space bar
            else
            {
                bird.gravityScale = berat;
                Debug.Log("gravity success");
            }
        }
    }
}
