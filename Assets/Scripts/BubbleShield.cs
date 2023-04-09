using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleShield : MonoBehaviour
{
    public GameObject shield;
    public float shieldTime;
   //audio
    public AudioSource source;
    public AudioClip clip; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("BubbleShield"))
        {
            source.PlayOneShot(clip);
            shield.gameObject.SetActive(true);
            Invoke("DownShield", shieldTime);
        }
    }
    void DownShield()
    {
        shield.gameObject.SetActive(false);
    }
}