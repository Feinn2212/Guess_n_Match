using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
