using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickItem : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    private AudioClip audioClip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("Item"))
        {
            Debug.Log("ชนกับ Item");

            //อยากให้ลบ Item ออกจากแมพ
            Destroy(target.gameObject);
            score += 10;

            scoreText.text = "Item x " + score.ToString();
            Debug.Log(score);

            audioSource.PlayOneShot(audioClip);
        }
    }
}
