using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundID : MonoBehaviour
{
    public int Groundid;
    // Start is called before the first frame update
    void Start()
    {
        Groundid = 0;
        StartCoroutine(GroundSelect());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GroundSelect()
    {
        while (true)
        {
            Groundid++;
            yield return new WaitForSeconds(10);
            if (Groundid > 2)
            {
                Groundid = 0;
            }
        }

    }
}
