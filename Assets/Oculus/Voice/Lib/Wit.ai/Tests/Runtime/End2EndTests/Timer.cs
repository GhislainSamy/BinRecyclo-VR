using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 10f;
    public GameObject terraindejeu;
    public GameObject BoutonSuivant;
    public GameObject BoutonRecommencer;
    public AudioSource audioSourceFin;
    public AudioSource BackgroundAudio;
    public AudioClip clip;
    public float volume=0.7f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
        time+=1; 
    }
    IEnumerator timer(){
        while(time>0)
        {
          time--;
          yield return new WaitForSeconds (1f);  
          GetComponent<Text> ().text = "Temps restants : " +time;
        }
        if(time==0){
         terraindejeu.gameObject.SetActive(false);
         BackgroundAudio.gameObject.SetActive(false);
         audioSourceFin.PlayOneShot(audioSourceFin.clip, volume);
         BoutonSuivant.gameObject.SetActive(true);
         BoutonRecommencer.gameObject.SetActive(true);


        }
    }
   
}
