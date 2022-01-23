using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
       
{
    public GameObject menue;
    public GameObject time;
    public static bool paused;

    public void Start()
    {
        time = GameObject.Find("Timer");
    }
    //replay level
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        menue.gameObject.SetActive(false);
        paused = false;
    }

    //quit game
    public void QuitGame()
    {
        Application.Quit();
    }

    //open menue on ESC
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menue.gameObject.activeSelf)
            { //Aktiv
                menue.gameObject.SetActive(false);
                time.GetComponent<Timer>().timerIsRunning = true;
                paused = false;

            }
            else //Inaktiv
            {
                menue.gameObject.SetActive(true);
                time.GetComponent<Timer>().timerIsRunning = false;
                paused = true;
            }
        }
    }
}
