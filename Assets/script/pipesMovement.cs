using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D pipe;

    float Ypipe;
    public float speed;
    float batasAtas = -2.0F;
    float batasBawah = 2.0F;
    void Start()
    {
        //pergerakan pipa dengan y random
        Ypipe = Random.Range(batasAtas, batasBawah);
    }

    // Update is called once per frame
    void Update()
    {
        //ketika belum kalah, maka tetap mengubah posisi pipa
        if (Time.timeScale != 0)
        {
            transform.localPosition = new Vector3(transform.localPosition.x - speed, Ypipe);
        }
    }
}
