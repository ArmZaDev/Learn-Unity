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
    private AudioClip completeSound;


    //ตัวแปรนับจำนวน Item
    int itemCount;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreText.text = "Item = " + score.ToString() + "/" + itemCount.ToString();
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("Item"))
        {          
            //อยากให้ลบ Item ออกจากแมพ
            Destroy(target.gameObject);
            score += 1;

            scoreText.text = "Item = " + score.ToString() + "/" + itemCount.ToString();
            if (score >= itemCount)
            {
                audioSource.PlayOneShot(completeSound);
            }
            else
            {
                audioSource.PlayOneShot(itemSound);
            }

            
        }
    }
}
