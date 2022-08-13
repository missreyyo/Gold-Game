using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerControl : MonoBehaviour
{
    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis ("Horizontal");
        float y = Input.GetAxis ("Vertical");
        x *= Time.deltaTime*speed;
        y *= Time.deltaTime*speed;
        transform.Translate(x,0f,y);
    }
}
