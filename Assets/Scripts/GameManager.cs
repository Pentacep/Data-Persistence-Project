using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public string playerName;


    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }



    public void SetName(string newName)
    {
        playerName = newName;
        Debug.Log("Name set to: " + playerName);
    }


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }



    public void Exit()
    {
        // MainManager.Instance.SaveColor();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }



}
