using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    Level level;
    GameStatus gameStatus;
    void Start()
    {
        level = FindObjectOfType<Level>();
        level.countNumOfBlocks();
        gameStatus = FindObjectOfType<GameStatus>();
     } 
         [SerializeField] AudioClip destroyBall;
         [SerializeField] GameObject particleEffect;
         [SerializeField] int timesHit = 0;
         [SerializeField] int maxHits;
         [SerializeField] Sprite[] sprites;

void Update()
{

}
private void OnCollisionEnter2D(Collision2D collision)
{
    timesHit ++;

    
    if(timesHit == maxHits)
    {
    AudioClip clip = destroyBall;
    Debug.Log(collision.gameObject.name);
    AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    level.decreaseNumOfBlocks();
    gameStatus.pointForBlockDestroyed();
    Destroy(gameObject);
    particle();
    }

    else {
        int spriteIndex = timesHit - 1;
        GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
    }


    if(timesHit == maxHits)
    {
    AudioClip clip = destroyBall;
    Debug.Log(collision.gameObject.name);
    AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    level.decreaseNumOfBlocks();
    gameStatus.pointForBlockDestroyed();
    Destroy(gameObject);
    particle();
    }

    
    
}

    public void particle()
    {
        GameObject particle = Instantiate(particleEffect, transform.position, transform.rotation);
        Destroy(particle, 1f);
    }
}
