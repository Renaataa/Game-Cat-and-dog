using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOverPanelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() 
    {
        
    }

    public void LoadLevelAgain(){
        Debug.Log("GameOverPanelController.LoadLevelAgain"+GameManager.instance.currentLevel);
        GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
    }
    
    public void LoadNextLevel(){
        
        GameManager.instance.currentLevel++;
        //Debug.Log(GameManager.instance.currentLevel);
        if(GameManager.instance.currentLevel < GameManager.instance.levelNames.Length){
            GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
        }
        else{
            GameManager.instance.currentLevel = 0;
            GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
        }
        Debug.Log("GameOverPanelController.LoadNextLevel"+GameManager.instance.currentLevel);
    }

    public void LoadMenu(){
        Debug.Log("GameOverPanelController.LoadMenu"+GameManager.instance.currentLevel);
        //Debug.Log(GameManager.instance.currentLevel);
        SceneManager.LoadScene("menu");
    }
}
