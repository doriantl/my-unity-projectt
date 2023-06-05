using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouv : MonoBehaviour
{
    GameObject Chara = null;
    Transform transf = null;
    public float  speed = 0;

    void Start()
    {
       Chara = gameObject;
       transf = Chara.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transf.position  += Vector3.left * speed;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transf.position  += Vector3.right * speed;
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            transf.position  += Vector3.up * speed;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transf.position  += Vector3.down * speed;
        }
       
    }
}
