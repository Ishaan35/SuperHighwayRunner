using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotationSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0); //some cars have a different rotation orientation, so this just sets their rotations if i apply script to them
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
