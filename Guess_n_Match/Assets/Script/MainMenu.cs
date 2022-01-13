using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject infoPanel;
    public void ToogleInfo()
    {
        infoPanel.SetActive(true);

    }
    
    public void closeInfo()
    {
        infoPanel.SetActive(false);
    }

    public void ConfirmExit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    public void nextScene()
    {
        SceneManager.LoadScene("Select GameType");
    }
}
