using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public StopCar stopcar; 
    public PlayerMove playermove;

    public Animator RestartButton;
    public Animator MenuButton;
    public Animator RestartFade;
    public Animator GameOver;

    public Canvas Startfade;

    public MoveCar movecar;
    public Score score;

    public static bool HighwayRacer;
    public static bool SuperHighwayRacer;
    public static bool NightRacer;

    public Animator Buttons;
    public Animator GamemodeSelectFade;

    public AudioSource buttonclick;


    public Animator howtoplay;

    private void Start()
    {
        StartCoroutine(CanvasOrder());
        buttonclick = GetComponent<AudioSource>();
    }
    private void Update()
    {
        //we reference the script controlling the player, and if moving bool is false, start function specified
        if (stopcar.Moving == false)
        {
            StartCoroutine(GameOverButtons());
        }
    }
    //animations
    public void playgame()
    {
        Buttons.SetBool("PlayButtonPressed", true);
    }
    public void BackToMenu()
    {
        Buttons.SetBool("PlayButtonPressed", false);      
    }

    
    

    public void RestartGame() //calline ienumerator for a button controllable function
    {
        StartCoroutine(RestartGameFunction());
    }

    IEnumerator RestartGameFunction() //if score is higher than the score contained in player prefs which is Highscore, then update it
    {
        if (Score.Scorenumber > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", Score.Scorenumber);
        }
        
        RestartFade.SetBool("restart", true); //controlling a fade
        yield return new WaitForSeconds(1.5f); 
        Score.Scorenumber = 0;//reset score to 0 and reset the speed increase bool in movecar script. This is because we are basically reseting the whole scene
        movecar.speedincrease1 = true;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    public void ReturnToMenu()
    {
        if (Score.Scorenumber > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", Score.Scorenumber);
        }
        buttonclick.Play(); //sound
        SceneManager.LoadScene("Start Menu");
    }

    IEnumerator GameOverButtons() //aimator controllers for presenting ui for after end of game
    {
        yield return new WaitForSeconds(1);
        RestartButton.SetBool("Gameover", true);
        MenuButton.SetBool("Gameover1", true);
        GameOver.SetBool("Gameover", true);
    }

    //the below is selecting the different scenes u can play 
    public void HighwayRacerSelect()
    {
        StartCoroutine(HighwayRacerSelect_());
    }

    IEnumerator HighwayRacerSelect_()
    {
        GamemodeSelectFade.SetBool("GamemodeSelected", true);
        Startfade.sortingOrder = 3;
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        HighwayRacer = true;
        SuperHighwayRacer = false;
        NightRacer = false;
    }
    public void NightRacerSelect()
    {
        StartCoroutine(NightRacerSelect_());
    }
    IEnumerator NightRacerSelect_()
    {
        GamemodeSelectFade.SetBool("GamemodeSelected", true);
        Startfade.sortingOrder = 3;
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        NightRacer = true;
        SuperHighwayRacer = false;
        HighwayRacer = false;
    }

    public void SuperHighwayRacerSelect()
    {
        StartCoroutine(SuperHighwayRacerSelect_());
    }

    IEnumerator SuperHighwayRacerSelect_()
    {
        
        GamemodeSelectFade.SetBool("GamemodeSelected", true);
        Startfade.sortingOrder = 3;
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        HighwayRacer = false;
        SuperHighwayRacer = true;
        NightRacer = false;
    }

    //when 
    IEnumerator CanvasOrder()
    {
        yield return new WaitForSeconds(0.5f);
        Startfade.sortingOrder = 0; //when done with fade, we reduce sorting order of fade, so we can interact with controls
        
    }

    //animations
    public void HowToPlay()
    {
        howtoplay.SetBool("HowToPlay", true);
    }
    public void HowToPlay1()
    {
        howtoplay.SetBool("HowToPlay", false);
    }

}
