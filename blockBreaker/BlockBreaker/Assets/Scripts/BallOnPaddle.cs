using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOnPaddle : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float xVel = 0f;
    [SerializeField] float yVel = 12f; 
    [SerializeField] AudioClip[] ballSounds;
   
   Vector2 paddlePosition;

   bool didBallShoot = false;
    AudioSource myAudioSource;
   
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        paddlePosition = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!didBallShoot)
        {
            lockBall();
            shootBall();
        }
        
    }
    private void shootBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
        GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
        didBallShoot = true;
        }
    }

    private void lockBall()
    {
        transform.position = (Vector2)paddle1.transform.position + (Vector2)paddlePosition;
    }
    private void OnCollisionEnter2D()
    {
        if(didBallShoot)
        {
        AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
        myAudioSource.PlayOneShot(clip);
        }


    }

}
