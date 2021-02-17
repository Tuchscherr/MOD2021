using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
   //This script allows you to toggle music to play and stop.
//Assign an AudioSource to a GameObject and attach an Audio Clip in the Audio Source. Attach this script to the GameObject.
    static Music instance = null;
    /*AudioSource m_MyAudioSource;
    public Texture2D controlTexture;
    public Texture2D controlTexture2;
    //public Sprite2D textura;
    //public GameObject Sonidoo;

    //Play the music
    bool m_Play;
    GUIStyle style;
    public bool val = false;
    //Detect when you use the toggle, ensures music isn’t played multiple times
    bool m_ToggleChange;
    //public static bool mute = false;*/

    private void Awake(){
            /*if(SceneManager.GetActiveScene().name == "Scene1"|| SceneManager.GetActiveScene().name == "Scene2"||SceneManager.GetActiveScene().name == "Scene3"){
                instance = null;
            }*/
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
        /*//Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        PlayerPrefs.SetInt("mute", 1);*/
        
    }

    void Update()
    {
         //if(m_ToggleChange == true){
            //Sonidoo.GetComponent<Renderer>().material.mainTexture = controlTexture2;
        //s}
        //Check to see if you just set the toggle to positive
        // 
        /*if (m_Play == true && m_ToggleChange == true)
        {
            //Play the audio you attach to the AudioSource component
            m_MyAudioSource.Play();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
            
        }
        //Check if you just set the toggle to false
        if (m_Play == false && m_ToggleChange == true)
        {
            //Stop the audio
            m_MyAudioSource.Stop();
            //m_Renderer.material.SetTexture("_MainTex", controlTexture2);
            
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;


        }*/
    }


    


    /*void OnGUI()
    {
        //Switch this toggle to activate and deactivate the parent GameObject
        if(SceneManager.GetActiveScene().name == "perfil1" || SceneManager.GetActiveScene().name == "perfil2" || SceneManager.GetActiveScene().name == "perfil3"|| SceneManager.GetActiveScene().name == "perfil4"|| SceneManager.GetActiveScene().name == "perfil5"|| SceneManager.GetActiveScene().name == "perfil6"|| SceneManager.GetActiveScene().name == "perfil7"|| SceneManager.GetActiveScene().name == "perfil8"|| SceneManager.GetActiveScene().name == "perfil9"|| SceneManager.GetActiveScene().name == "perfil10"|| SceneManager.GetActiveScene().name == "perfil11"|| SceneManager.GetActiveScene().name == "perfil12"|| SceneManager.GetActiveScene().name == "perfil13"|| SceneManager.GetActiveScene().name == "perfil14"|| SceneManager.GetActiveScene().name == "perfil15"|| SceneManager.GetActiveScene().name == "perfil16" || SceneManager.GetActiveScene().name == "perfil17"){
            GUI.skin.toggle = style;
            val = GUILayout.Toggle(val, " ");
            m_Play = GUI.Toggle(new Rect(400, 287, 100, 30), m_Play, controlTexture);
        }
        else if(SceneManager.GetActiveScene().name == "Combate1"){
            GUI.skin.toggle = style;
            val = GUILayout.Toggle(val, " ");
            m_Play = GUI.Toggle(new Rect(10, 285, 100, 30), m_Play, controlTexture);
        }else{
            GUI.skin.toggle = style;
            val = GUILayout.Toggle(val, " ");
            m_Play = GUI.Toggle(new Rect(10, 10, 100, 30), m_Play, controlTexture);
        }
        
         //m_Play, "PLAY"

        //Detect if there is a change with the toggle
        if (GUI.changed)
        {
            
            //mute = true;
            
            //Change to true to show that there was just a change in the toggle state
            m_ToggleChange = true;
        }
       


    }*/

}
