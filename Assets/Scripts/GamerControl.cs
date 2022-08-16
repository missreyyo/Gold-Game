using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerControl : MonoBehaviour
{
    
    public GameControl GameControl;
    public UnityEngine.UI.Button tryAgain;
    private float speed = 10;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameControl.gameActive){
        float x = Input.GetAxis ("Horizontal");
        float y = Input.GetAxis ("Vertical");
        x *= Time.deltaTime*speed;
        y *= Time.deltaTime*speed;
        transform.Translate(x,0f,y);
        }
    }
    void OnCollisionEnter(Collision c){
        if(c.gameObject.tag.Equals("Gold")){
           
            GameControl.goldplus();
            Destroy (c.gameObject);
             

        }
        else if(c.gameObject.tag.Equals("enemies")){
            GameControl.gameActive=false;
            tryAgain.gameObject.SetActive(true);

        }
    }
}
