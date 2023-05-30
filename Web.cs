using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class Web : MonoBehaviour
{
        public TMP_Text HighscoresText;

    void Start()
    {
        // A correct website page.
        // StartCoroutine(GetUsers());
        // StartCoroutine(Login("admin", "admin"));
        // StartCoroutine(Register("uros", "123"));
    }

    IEnumerator GetDate()
    {
       using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/UnityPHP/GetDate.php")) {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError) {
                Debug.Log(www.error);
            } else {
                // Show results as text
                Debug.Log(www.downloadHandler.text);

                // Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
       }
    }

    IEnumerator GetUsers()
    {
       using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/UnityPHP/getUsers.php")) {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError) {
                Debug.Log(www.error);
            } else {
                // Show results as text
                Debug.Log(www.downloadHandler.text);

                // Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
       }
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUsername", username);
        form.AddField("loginPassword", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityPHP/login.php", form))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                if(www.downloadHandler.text == "bad") {
                    Debug.Log("Bad credentials!");
                } else {
                Debug.Log(www.downloadHandler.text);
                Main.Instance.UserInfo.SetCredentials(username, password);
                Main.Instance.UserInfo.SetdbHighscore(www.downloadHandler.text);
                }
            }
        }
    }

    public IEnumerator Register(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUsername", username);
        form.AddField("loginPassword", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityPHP/register.php", form))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    public IEnumerator UpdateHighscore(string username, int score)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUsername", username);
        form.AddField("score", score);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityPHP/updatehighscore.php", form))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }


    public IEnumerator GetScore()
    {
        // WWWForm form = new WWWForm();

        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/UnityPHP/getScore.php"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string jsonArray = www.downloadHandler.text;
                HighscoresText.text = "Radi";
            }
        }
    }
}