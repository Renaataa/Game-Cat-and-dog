using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public int currentLevel = 0;
    public string[] levelNames;

    void Awake(){
        Debug.Log("GameManager.Awake");
        if(instance == null){
            instance = this;
        }
        else if(instance != this){
            //Debug.Log(currentLevel);
            //instance = null;
            //instance = this;
            //Debug.Log(currentLevel);
            //Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameManager.Start");
        /*if(PlayerPrefs.HasKey("currentLevel")){
            currentLevel = PlayerPrefs.GetInt("currentLevel");
        }*/
    }

    public void OpenLevel(int newLevelNum)
    {
        Debug.Log("GameManager.OpenLevel");
        SceneManager.LoadScene(levelNames[newLevelNum]);
    }

    public void OpenCurrentLevel(){
        Debug.Log("GameManager.OpenCurrentLevel "+currentLevel);
        OpenLevel(currentLevel);
    }

    public void CloseApplication(){
        Debug.Log("GameManager.CloseApplication");
        //PlayerPrefs.SetInt("currentLevel", currentLevel);
        Application.Quit();
    }
}
