using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispawnObjet : MonoBehaviour
{   
    public AudioSource audioSourcefail;
    public AudioClip clip;
    public float volume=0.7f;

 void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pvert" || other.gameObject.tag == "pjaune" || other.gameObject.tag == "pbleu")
        {
            audioSourcefail.PlayOneShot(audioSourcefail.clip, volume);
            ScoreManager.instance.AddBadPoint();
            other.gameObject.SetActive(false);
        }
    }
}