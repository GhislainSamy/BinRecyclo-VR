using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
   public void niveau1(){
       SceneManager.LoadScene("Niveau_1");
   }
    public void niveau2(){
       SceneManager.LoadScene("Niveau_2");
   }
}
