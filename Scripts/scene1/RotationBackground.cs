using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotationBackground : MonoBehaviour
{
    
    public float rs = 1;

    void Update()
    {
        this.transform.Rotate(0, 0, rs, Space.World);
    }
}
