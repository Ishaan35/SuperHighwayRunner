using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuGroundSpawn : MonoBehaviour
{
    public bool IsSpawn_ = true;
    public GameObject Ground_;
    public Transform InstantiateLocation_;
    // Start is called before the first frame update
    void Start()
    {
        IsSpawn_ = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Collision)
    {
        if (IsSpawn_== true) //simple spawn
        {
            GameObject clone = Instantiate(Ground_, InstantiateLocation_.position, InstantiateLocation_.rotation);
            Destroy(clone, 35);
            IsSpawn_ = false;
        }
        
    }
}
