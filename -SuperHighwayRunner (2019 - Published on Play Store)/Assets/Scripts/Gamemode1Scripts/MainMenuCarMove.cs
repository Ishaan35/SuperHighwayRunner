using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCarMove : MonoBehaviour
{
    public GameObject Player;
    public float velocity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        transform.Translate(0f, 0f, velocity * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
