using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    SceneLoader sceneLoader;
    GameStatus gameStatus;
    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        gameStatus = FindObjectOfType<GameStatus>();
    }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    //   sceneLoader = FindObjectOfType<SceneLoader>();
      SceneManager.LoadScene("EndGame");
    // gameStatus.destroyObject();
    // sceneLoader.loadStartScene();
  }
}
