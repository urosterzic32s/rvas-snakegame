using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    public TMP_InputField UsernameInput;
    public TMP_InputField PasswordInput;
    public Button RegisterButton;

    // Start is called before the first frame update
    void Start()
    {
        RegisterButton.onClick.AddListener(() => {
            StartCoroutine(Main.Instance.Web.Register(UsernameInput.text, PasswordInput.text));
        });
        
    }
}
