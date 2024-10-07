using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    
    private float rotationH = 0f;
    private float rotationV = 0f;

    public float sensitivityZ = 2f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(-Input.GetAxis("Vertical") * speed, 0, -Input.GetAxis("Horizontal") * speed);
        lockedRotation();
    }


    void lockedRotation()
    {
        rotationH += Input.GetAxis("Horizontal") * sensitivityZ;
        rotationV += Input.GetAxis("Vertical") * sensitivityZ;
        rotationH = Mathf.Clamp(rotationH, -40, 40);
        rotationV = Mathf.Clamp(rotationV, -25, 25);

        transform.localEulerAngles =
            new Vector3(rotationV, transform.localEulerAngles.y, -rotationH);
    }
}