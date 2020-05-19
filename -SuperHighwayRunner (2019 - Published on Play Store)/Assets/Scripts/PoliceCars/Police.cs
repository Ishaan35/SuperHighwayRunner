using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{
    [SerializeField]
    public int speed = 10, rotatespeed = 10;

    public GameObject target;
    public Rigidbody rb;

    public BoxCollider bc;

    public Transform player;

    public GameObject police;

    public Behaviour Halo;
    public Behaviour Halo2;

    public StopCar stopcar;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();

        bc.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(Lights());
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
        
                      
            {
                Vector3 pointTarget = transform.position - target.transform.position;
                pointTarget.Normalize();

                float value = Vector3.Cross(pointTarget, transform.forward).y;

                rb.angularVelocity = rotatespeed * value * new Vector3(0, 1, 0);
                rb.velocity = transform.forward * speed;
            }


        

    }

     void Update()
    {
        if (Vector3.Distance(player.position, this.transform.position) > 1f)
        {
            bc.GetComponent<BoxCollider>().enabled = false;
        }
        if (Vector3.Distance(player.position, this.transform.position) < 1f)
        {
            bc.GetComponent<BoxCollider>().enabled = true;
        }

        if (Vector3.Distance(player.position, this.transform.position) < 1.1f)
        {
            speed = 1;
        }
        if (Vector3.Distance(player.position, this.transform.position) < 2.5f && Vector3.Distance(player.position, this.transform.position) > 1.1f)
        {
            speed = 5;
        }
        if (Vector3.Distance(player.position, this.transform.position) > 2.5)
        {
            speed = 26;
        }

        

    }





    IEnumerator Lights()
    {
        while(true)
        {
            Halo.enabled = true;
            Halo2.enabled = false;
            yield return new WaitForSeconds(0.35f);
            Halo.enabled = false;
            Halo2.enabled = true;
            yield return new WaitForSeconds(0.35f);
        }
        
    }
}
