using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianCarDestroy2 : MonoBehaviour
{
    public float movespeed = 0.1f;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CivilianDestroyer")
        {
            Destroy(gameObject);
        }
        

    }

    

    IEnumerator Move()
    {
        while(true)
        {
            gameObject.transform.position += new Vector3(0, 0, movespeed);
            yield return new WaitForSeconds(0.03f);
        }
    }

    

}
