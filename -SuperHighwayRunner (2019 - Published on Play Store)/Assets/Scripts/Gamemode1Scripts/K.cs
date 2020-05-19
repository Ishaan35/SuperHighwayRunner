using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class K : MonoBehaviour

    
{
    public float k = 0;

    public StopCar stopcar;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GroundSelect());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GroundSelect()
    {
        while(true)
        {
            k++;
            yield return new WaitForSeconds(10);
            if (k > 2)
            {
                k = 0;
            }
        }
        
    }
    
}
