using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    
    // Update is called once per frame
    void Update ()
    {
        this.transform.Rotate(eulerAngles: new Vector3(x: 15, y: 30, z: 45) * Time.deltaTime);	
    }
}
