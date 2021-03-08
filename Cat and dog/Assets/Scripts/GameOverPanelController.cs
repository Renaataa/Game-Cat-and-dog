using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadLevelAgain(){
        Debug.Log(GameManager.instance.currentLevel);
        GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
    }
    
    public void LoadNextLevel(){
        GameManager.instance.OpenLevel(GameManager.instance.currentLevel+1);
    }
}
