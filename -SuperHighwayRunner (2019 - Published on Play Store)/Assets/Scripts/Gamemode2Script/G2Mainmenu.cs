using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class G2Mainmenu : MonoBehaviour
{
    
    public PlayerMove playermove;

    public Animator RestartButton;
    public Animator MenuButton;
    public Animator RestartFade;
    public Animator GameoverText;

    public G2Score g2score;

    

    private void Start()
    {
        
    }

    


  

    private void Update()
    {
        if (playermove.PLAYERMOVING == false)
        {
            StartCoroutine(GameOverButtons());
        }

       
    }

    public void playgame()
    {
        StartCoroutine(Playgame());
    }
    public IEnumerator Playgame()
    {
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void RestartGame()
    {
        StartCoroutine(RestartGameFunction());
    }

    IEnumerator RestartGameFunction()
    {
        RestartFade.SetBool("restart", true);
        if (G2Score.G2Scorenumber > PlayerPrefs.GetFloat("HighscoreG2", 0))
        {
            PlayerPrefs.SetFloat("HighscoreG2", G2Score.G2Scorenumber);
            g2score.HighscoreG2.text = G2Score.G2Scorenumber.ToString("0");
        }
        yield return new WaitForSeconds(1.5f);
        G2Score.G2Scorenumber = 0;
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    public void ReturnToMenu()
    {
        if (G2Score.G2Scorenumber > PlayerPrefs.GetFloat("HighscoreG2", 0))
        {
            PlayerPrefs.SetFloat("HighscoreG2", G2Score.G2Scorenumber);
            g2score.HighscoreG2.text = G2Score.G2Scorenumber.ToString("0");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        
    }

    IEnumerator GameOverButtons()
    {
        
        yield return new WaitForSeconds(2);
        RestartButton.SetBool("Gameover", true);
        MenuButton.SetBool("Gameover1", true);
        GameoverText.SetBool("Gameover", true);
    }

 
}
