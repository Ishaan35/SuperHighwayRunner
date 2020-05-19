
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class RightMove : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    private bool Pressed;
    public GameObject car;
    public MoveCar movecar;
    public GameObject Lane1Spawner;
    public GameObject Lane2Spawner;
    public GameObject Lane3Spawner;



    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {




    }


    public void OnPointerDown(PointerEventData eventData)
    {

        Pressed = true;
        if (movecar.LaneChange < 1)
        {
            StartCoroutine(Right());
            StartCoroutine(Lane1Spawnerleft());
            StartCoroutine(Lane2Spawnerleft());
            StartCoroutine(Lane3Spawnerleft());
            movecar.LaneChange++;
        }
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }

    IEnumerator Right()
    {
        for (int r = 0; r < 10; r++)
        {
            car.transform.position += new Vector3(0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }

    }

    IEnumerator Lane1Spawnerleft()
    {
        for (int r = 0; r < 10; r++)
        {
            Lane1Spawner.transform.position += new Vector3(-0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }

    }
    IEnumerator Lane2Spawnerleft()
    {
        for (int r = 0; r < 10; r++)
        {
            Lane2Spawner.transform.position += new Vector3(-0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }

    }
    IEnumerator Lane3Spawnerleft()
    {
        for (int r = 0; r < 10; r++)
        {
            Lane3Spawner.transform.position += new Vector3(-0.1f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }

    }


}