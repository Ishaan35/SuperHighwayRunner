using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float Velocity1;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Accelerate());
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Accelerate()
    {
        for (float v = 0; v > -8; v--)
        {
            Velocity1--;
            yield return new WaitForSeconds(0.2f);
        }
    }

}
