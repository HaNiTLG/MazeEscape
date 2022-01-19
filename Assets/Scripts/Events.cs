using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
       
{
    public Panel panel;
    //replay level
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //quit game
    public void QuitGame()
    {
        Application.Quit();
    }

    //open menue on ESC
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.gameObject.setActive(true);
        }
    }
    */
}
