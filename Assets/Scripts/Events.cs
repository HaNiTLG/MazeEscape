using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
       
{
    public GameObject menue;
    public GameObject time;
    public GameObject text;
    public static bool paused;

    public void Start()
    {
        time = GameObject.Find("Timer");
        text = GameObject.Find("Pause_GO");
        menue.gameObject.SetActive(false);
        paused = false;

    }
    //replay level
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //menue.gameObject.SetActive(false);
        //paused = false;
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
                Cursor.visible = true;
                menue.gameObject.SetActive(false);
                time.GetComponent<Timer>().timerIsRunning = true;
                paused = false;

            }
            else //Inaktiv
            {
                Cursor.visible = false;
                menue.gameObject.SetActive(true);
                time.GetComponent<Timer>().timerIsRunning = false;
                paused = true;
            }
        }
        else
        {
            if (time.GetComponent<Timer>().timeValue <= 0.1) //GAME OVER
            {
                Cursor.visible = true;
                text.GetComponent<UnityEngine.UI.Text>().text = "GAME OVER";
                //Debug.Log("GAME OVER1");
                menue.gameObject.SetActive(true);
                paused = true;
            }
        }
    }
}
