using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music3 : MonoBehaviour
{
    //This script allows you to toggle music to play and stop.
    //Assign an AudioSource to a GameObject and attach an Audio Clip in the Audio Source. Attach this script to the GameObject.
    static Music3 instance = null;


    private void Awake(){
           
            if(instance !=null){
                Destroy(gameObject);
            }else{
                instance = this;
                GameObject.DontDestroyOnLoad(gameObject);
            }
    }

    public void ToggleSound(){
        if(PlayerPrefs.GetInt("mute",0) == 0){
                PlayerPrefs.SetInt("mute", 1);
            }else{
                PlayerPrefs.SetInt("mute", 0);
            }
    }
    
    void Start()
    {
        PlayerPrefs.SetInt("mute", 0);
        
    }

    void Update()
    {
         
    }

}
