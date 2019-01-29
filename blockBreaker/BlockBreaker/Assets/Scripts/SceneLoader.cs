using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    GameStatus gameStatus;
    void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
    }
    public void loadNextScene()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        
        public void loadStartScene()
        {
        gameStatus.destroyObject();
        SceneManager.LoadScene(0);
        }
    
}
