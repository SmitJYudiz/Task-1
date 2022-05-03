using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationExample : MonoBehaviour
{

 public   float rotationSpeed = 45;

    //public float rotationValueForPoints = 0.01f;

   public  float x;
    public float y;
    public float z;

    public float temp;

    Vector3 currentEulerAngles;

    // Start is called before the first frame update
    void Start()
    {
       /* x= rotationValueForPoints;
        y= rotationValueForPoints;
        z= rotationValueForPoints;*/
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.X))
        {

            //temp= 1 - x;
            x = 1 - x;
            currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotationSpeed;

            Debug.Log("value of temp: " + temp);
        }
        if (Input.GetKeyDown(KeyCode.Y)) y = 1 - y;
        if (Input.GetKeyDown(KeyCode.Z)) z = 1 - z;

        //modifying the input based on speed and time and vector3
        
        //apply the change to the gameObject.
        transform.eulerAngles = currentEulerAngles;
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 24;
        GUI.Label(new Rect(10, 0, 0, 0), "Rotating on X: " + x + "  Y:" + y+ "  Z: "+z, style);

        GUI.Label(new Rect(10, 25, 0, 0), "Transform.eulerAngle:" + transform.eulerAngles, style);
    }
}
