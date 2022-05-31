using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ontriggerBLEU : MonoBehaviour
{   
    public AudioSource audioSourceWin;
    public AudioSource audioSourcefail;
    public AudioClip clip;
    public float volume=0.5f;

 void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pbleu")
        {
            audioSourceWin.PlayOneShot(audioSourceWin.clip, volume);
            other.gameObject.SetActive(false);
			ScoreManager.instance.AddPoint();
			Debug.Log(this.gameObject);
        }
        else
        {
            audioSourcefail.PlayOneShot(audioSourcefail.clip, volume);
            ScoreManager.instance.AddBadPoint();
            other.gameObject.SetActive(false);
        }
    }
}