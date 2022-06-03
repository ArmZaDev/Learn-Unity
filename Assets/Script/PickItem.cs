using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickItem : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    private AudioClip itemSound;


    //ตัวแปรนับจำนวน Item
    int itemCount;
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider target)
    {
       
    }
}
