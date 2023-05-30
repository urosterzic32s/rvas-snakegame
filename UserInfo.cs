using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserInfo : MonoBehaviour
{
    string UserID;
    string UserName;
    string UserPassword;
    string dbHighscore; 

    public void SetCredentials(string username, string userpassword) {
        PlayerPrefs.SetString("username", username);
        PlayerPrefs.SetString("password", userpassword);
    }

    public void SetdbHighscore(string dbhighscore) {
        PlayerPrefs.SetInt("highscore", int.Parse(dbhighscore));
    }
}
