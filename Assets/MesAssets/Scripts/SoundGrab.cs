using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundGrab : MonoBehaviour
{   
    public AudioSource audioSourcePVERT;
    public AudioSource audioSourcePJAUNE;
    public AudioSource audioSourcePBLEU;
    public AudioClip clip;
    public float volume=0.5f;
    public float cooldownTime = 1f;
    private bool inCooldown;

    private IEnumerator Cooldown()
    {
        //Set the cooldown flag to true, wait for the cooldown time to pass, then turn the flag to false
        inCooldown = true;
        yield return new WaitForSeconds(cooldownTime);
        inCooldown = false;
    }

 void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pvert")
        {
            if(!inCooldown){
            audioSourcePVERT.PlayOneShot(audioSourcePVERT.clip, volume);
			Debug.Log(this.gameObject);
            StartCoroutine(Cooldown());
            }
        }
         if(other.gameObject.tag == "pjaune")
        {
            audioSourcePJAUNE.PlayOneShot(audioSourcePJAUNE.clip, volume);
			Debug.Log(this.gameObject);
        }
         if(other.gameObject.tag == "pbleu")
        {
            audioSourcePBLEU.PlayOneShot(audioSourcePBLEU.clip, volume);
			Debug.Log(this.gameObject);
        }
        
    }
    
}