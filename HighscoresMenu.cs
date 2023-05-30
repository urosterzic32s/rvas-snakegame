using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class HighscoresMenu : MonoBehaviour
{
    public static class JsonHelper
{
    // Deserialize a JSON array into a list of objects
    public static List<T> FromJson<T>(string jsonArray)
    {
        jsonArray = WrapArray(jsonArray);
        return UnityEngine.JsonUtility.FromJson<Wrapper<T>>(jsonArray).items;
    }

    // Wrap the JSON array string to match the structure expected by Unity's JsonUtility
    private static string WrapArray(string jsonArray)
    {
        return "{\"items\":" + jsonArray + "}";
    }

    // Wrapper class to match the structure expected by Unity's JsonUtility
    [System.Serializable]
    private class Wrapper<T>
    {
        public List<T> items;
    }
}
    public TMP_Text highscoresText;
    [System.Serializable]

    public class UserData
    {
        public string username;
        public int highscore;
    }

    // Start is called before the first frame update
    void Start()
    {
            StartCoroutine(GetScore());
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
                
                // ProcessScoresResponse(jsonArray);


                List<UserData> dataList = JsonHelper.FromJson<UserData>(jsonArray);

                   // Create a string to store the extracted data
                  string extractedData = "";
                    int x=1;
                  // Extract data from the list
                  foreach (UserData data in dataList)
                 {
                    extractedData += x +  ". " + data.username + " ";
                    extractedData += data.highscore.ToString() + "\n" + "-------------\n";
                    x++;
                 }

        // Display the extracted data in the text object
                highscoresText.text = extractedData;




                // highscoresText.text = "Radii";

            }
        }
    }

    //   void ProcessScoresResponse(string response)
    // {
    //     string[] lines = response.Split('\n');

    //     foreach (string line in lines)
    //     {
    //         string[] data = line.Split(',');

    //         if (data.Length >= 2)
    //         {
    //             string username = datausername;
    //             string  highscore = data.highscore;

    //             Debug.Log("Username: " + username + ", Highscore: " + highscore);
    //         }
    //     }
    // }

}