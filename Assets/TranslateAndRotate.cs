using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateAndRotate : MonoBehaviour
{
    public float moveSpeed = 10;


    // Start is called before the first frame update
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Z))
        

        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * moveSpeed);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

    }

    
}
