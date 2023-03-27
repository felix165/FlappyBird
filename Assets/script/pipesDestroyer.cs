using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    //mendeteksi object "pipe"
    //ketika terdeteksi, object akan dihancurkan
    void OnTriggerEnter2D (Collider2D obj)
    {
        if (obj.gameObject.name == "pipe")
        {
            Destroy(obj.gameObject.transform.parent.gameObject);
        }
    }
}
