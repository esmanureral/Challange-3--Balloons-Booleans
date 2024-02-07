using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;//Tekrar genişliği

    private void Start()
    {
        startPos = transform.position; //Başlangıç pozisyonu
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; //Tekrar genişliği arka planın yarısı
    }

    private void Update()
    {
        //Arka plan,tekrar genişliği kadar sola hareket ederse başlangıç konumuna geri taşıyın.
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}


