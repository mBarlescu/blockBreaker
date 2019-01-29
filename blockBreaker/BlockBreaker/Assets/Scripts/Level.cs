using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour
{
    [SerializeField] int numOfBlocks;

    SceneLoader sceneLoader;

    
    // Start is called before the first frame update
    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    public void countNumOfBlocks()
    {
        numOfBlocks++;
    }
    // Update is called once per frame
    void Update()
    {
        if (numOfBlocks <= 0)
        {
            sceneLoader.loadNextScene();
        }
    }

    public void decreaseNumOfBlocks()
    {
        numOfBlocks--;
    }
}
