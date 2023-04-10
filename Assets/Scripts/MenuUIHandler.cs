using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;

    // To load game scene
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // To get player name from inputfield
    public void SetPlayerName()
    {
        PlayerDataHandler.Instance.PlayerName = PlayerNameInput.text;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
