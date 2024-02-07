using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed = 30;
    private PlayerControllerX playerControllerScript;
    private float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // oyun bitmediyse
        if (playerControllerScript.gameOver==false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        //sahneden çıkanı yok etme
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
