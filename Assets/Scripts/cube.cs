using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    float time = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       time -=Time.deltaTime;
       if(time<0){
        GetComponent<Animator> ().Play (0);
        time = Random.Range (5,10);
       }
    }
}
