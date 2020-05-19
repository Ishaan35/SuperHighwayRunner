
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class LeftMove : MonoBehaviour, IPointerUpHandler, IPointerDownHandler //touch screen enabled
{

    private bool Pressed;
    public GameObject car;
    public MoveCar movecar;
    public GameObject Lane1spawner;
    public GameObject Lane2spawner;
    public GameObject Lane3spawner;



    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {




    }


    public void OnPointerDown(PointerEventData eventData) //if pressing down
    {

        Pressed = true;
        if (movecar.LaneChange > -1) // if we are not in the leftmost lane, we move let, and move every spawner to the right by same amount
        {
            StartCoroutine(Left());
            StartCoroutine(Lane1Spawnerright());
            StartCoroutine(Lane2Spawnerright());
            StartCoroutine(Lane3Spawnerright());
            movecar.LaneChange--;
        }

        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }

    IEnumerator Left() //left move and right spawner move functions
    {
        for (int l = 0; l < 10; l++)
        {
            car.transform.position += new Vector3(-0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Lane1Spawnerright()
    {
        for (int l = 0; l < 10; l++)
        {
            Lane1spawner.transform.position += new Vector3(0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator Lane2Spawnerright()
    {
        for (int l = 0; l < 10; l++)
        {
            Lane2spawner.transform.position += new Vector3(0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator Lane3Spawnerright()
    {
        for (int l = 0; l < 10; l++)
        {
            Lane3spawner.transform.position += new Vector3(0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }

}