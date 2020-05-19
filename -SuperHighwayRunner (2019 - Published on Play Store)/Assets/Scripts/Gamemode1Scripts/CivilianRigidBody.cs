using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianRigidBody : MonoBehaviour
{
    public Transform player;

    public bool IsKinematic;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        IsKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        //modify the cars' rigidbody when close

        if (Vector3.Distance(player.position, this.transform.position) < 2)
        {
            IsKinematic = true;
        }

        if (IsKinematic == true)
        {
            rb.isKinematic = false;
        }
        
    }
}
