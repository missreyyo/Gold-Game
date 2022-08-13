using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    float sensibility = 5f;
    float softness =2f;

    Vector2 nextPos;
    Vector2 camPos;

    GameObject gamer;
    // Start is called before the first frame update
    void Start()
    {
        gamer =transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        mousePos = Vector2.Scale(mousePos,new Vector2(sensibility*softness,sensibility*softness));
        nextPos.x = Mathf.Lerp (nextPos.x,mousePos.x,1f/softness);
        nextPos.y = Mathf.Lerp (nextPos.y,mousePos.y,1f/softness);
        camPos += nextPos;
        transform.localRotation = Quaternion.AngleAxis(-camPos.y,Vector3.right);
        gamer.transform.localRotation = Quaternion.AngleAxis (camPos.x,gamer.transform.up);

    }
}
