using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int score = 0;
    [SerializeField] int pointsPerBlockDestroyed = 93;
    [SerializeField] TextMeshProUGUI scoreText;

   

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            
            Destroy(gameObject);
        }
        else
        {
         
            DontDestroyOnLoad(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
        scoreText.text = score.ToString();
    }

    public void pointForBlockDestroyed()
    {
        score += pointsPerBlockDestroyed;
    }
    public void destroyObject()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
