using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce = 1.5f;
    private float gravityModifier; //yer çekimi değiştirici
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;


    void Start()
    {
        playerRb=GetComponent<Rigidbody>();

        
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * floatForce,ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // Oyuncu bombayla çarpışırsa gameover
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // oyuncu parayla çarpışırsa devam
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

    }

}
