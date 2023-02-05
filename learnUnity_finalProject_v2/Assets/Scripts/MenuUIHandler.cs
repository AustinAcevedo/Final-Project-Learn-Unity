using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    public string playerName;
    public RuntimePersistentData runtimePersistentData;




    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void SetPlayerName()
    {
        playerName = inputField.text;
        runtimePersistentData.currentUser = playerName;
    }


}
