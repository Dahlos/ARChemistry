using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronMovement : MonoBehaviour
{
    public float angleRotation = 10f;
    Vector3[] vectorAxises = new Vector3[7];
    public Axistorotate axisRotate;
    public Transform parentObject;
    void Start()
    {   
        vectorAxises[0] = Vector3.back;
        vectorAxises[1] = Vector3.down;
        vectorAxises[2] = Vector3.forward;
        vectorAxises[3] = Vector3.left;
        vectorAxises[4] = Vector3.right;
        vectorAxises[5] = Vector3.up;
        vectorAxises[6] = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(parentObject.position, axis: vectorAxises[(int)axisRotate], angle: angleRotation);
        transform.RotateAround(parentObject.position, axis: vectorAxises[(int)axisRotate], angle: angleRotation);
    }

    public enum Axistorotate { Back, Down, Forward, Left, Right, Up, Zero };

}
