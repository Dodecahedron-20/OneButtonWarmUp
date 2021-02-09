using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

  //Game objects
  [SerializeField]
  private GameObject MenuBase;

  [SerializeField]
  private GameObject MenuEnd;

  [SerializeField]
  private GameObject YouWinTxt;

  [SerializeField]
  private GameObject YouLooseTxt;


  //Keycodes go here
  [SerializeField]
  private KeyCode Action;

  [SerializeField]
  private KeyCode Quit;

//telling if game is active, and if it's got to the end
  private bool gameOn;
  private bool end;



    // Start is called before the first frame update
    void Start()
    {
      Time.timeScale = 0;
      MenuBase.SetActive(true);
      gameOn = false;
      end = false;
      MenuEnd.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(Action))
      {
        if(gameOn != true)
        {
          if(end == false)
          {
            StartGame();
          }
          else
          {
            RestartGame();
          }

        }
      }

      if (Input.GetKeyDown(Quit))
      {
        QuitGame();
      }

    }

    void YouWin()
    {
      Time.timeScale = 0;
      end = true;
      gameOn = false;
      MenuEnd.SetActive(true);
      YouWinTxt.SetActive(true);
    }

    void YouLoose()
    {
      Time.timeScale = 0;
      end = true;
      gameOn = false;
      MenuEnd.SetActive(true);
      YouLooseTxt.SetActive(false);
    }

    void StartGame()
    {
      MenuBase.SetActive(false);
      Time.timeScale = 1;
      gameOn = true;
    }

    void RestartGame()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void QuitGame()
    {
      //Application.Quit;
    }








}
