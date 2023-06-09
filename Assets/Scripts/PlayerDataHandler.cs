using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandler : MonoBehaviour
{
    //Static Class to save the current player data;

    public static PlayerDataHandler Instance;
    public string PlayerName;
    public int score;

    //Singleton pattern

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
