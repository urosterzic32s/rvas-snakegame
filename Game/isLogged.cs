using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isLogged : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject menuPanel;
    // Start is called before the first frame update
    void Update()
    {
        if (PlayerPrefs.HasKey("username"))
        {
            loginPanel.SetActive(false);
            menuPanel.SetActive(true);
        }
        else
        {
            loginPanel.SetActive(true);
            menuPanel.SetActive(false);
        }
    }

}
