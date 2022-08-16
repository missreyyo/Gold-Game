using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    
    public bool gameActive=true;
    public int gold=0;
    public UnityEngine.UI.Text goldtext;
    public UnityEngine.UI.Button startButton;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<AudioSource> ().Play (); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goldplus(){
        gold +=1;
        goldtext.text = "" + gold;
    }
    public void startGame(){
        gameActive=true;
        startButton.gameObject.SetActive (false);

    }
}
