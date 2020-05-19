using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelectAnim : MonoBehaviour
{
    public GameObject Cars;
    public float MoveDistance = -0.105f;

    public Animator CarSelectFade;
    public Canvas CarSelectFadePanel;

    public AudioSource ButtonClick;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeSortOrder());
        ButtonClick = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ShiftLeft() //when pressing arrow, we just move the cars in the selection to the left, and then right respectively in the next function
    {
        for (int i = 0; i < 6; i++)
        {
            Cars.transform.position += new Vector3(-MoveDistance, 0, 0);
            yield return new WaitForSeconds(0.001f);
        }
        ButtonClick.Play();
        
    }
    public IEnumerator ShiftRight()
    {
        for (int i = 0; i < 6; i++)
        {
            Cars.transform.position += new Vector3(MoveDistance, 0, 0);
            yield return new WaitForSeconds(0.001f);
        }
        ButtonClick.Play();

    }

    //since we cant call ienumerators from button clicks, we will jsut call them from void functions that can be activated from button clicks
    public void RightAnim()
    {
        StartCoroutine(ShiftRight());
    }
    public void LeftAnim()
    {
        StartCoroutine(ShiftLeft());
    }
    public void SceneChange() //calling ienumerator from void
    {
        StartCoroutine(SceneChange_());
    }

    //same concept, but changing scenes with fade according to build index
    IEnumerator SceneChange_()
    {
        CarSelectFade.SetBool("ToGame", true); //fade animator starting animations
        CarSelectFadePanel.sortingOrder = 4; //inreasing sorting order of fade to cover everything
        yield return new WaitForSeconds(1);
        
        if (MainMenu.HighwayRacer == true && MainMenu.SuperHighwayRacer == false && MainMenu.NightRacer == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (MainMenu.SuperHighwayRacer == true && MainMenu.HighwayRacer == false && MainMenu.NightRacer == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        if (MainMenu.NightRacer == true && MainMenu.HighwayRacer == false && MainMenu.SuperHighwayRacer == false)
        {
            SceneManager.LoadScene("GameNight");
        }

    }

    IEnumerator FadeSortOrder() //changing sorting order, in order to prevent any ui interruptions
    {
        yield return new WaitForSeconds(0.5f);
        CarSelectFadePanel.sortingOrder = 0;
    }





}
