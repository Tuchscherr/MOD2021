using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundScript : MonoBehaviour
{
    private Music musica;
    public Button musicToggleButton;
    public Sprite musicOnSprite;
    public Sprite musicOffSprite;
    public AudioClip otro;

    void Awake(){

        /*AudioSource source = musica.GetComponent<AudioSource> ();
        if(SceneManager.GetActiveScene().name == "perfil1"){
            source.clip = otro;
            source.Play();
        }*/
    }
   
    // Start is called before the first frame update
    void Start()
    {
        musica = GameObject.FindObjectOfType<Music>();
        UpdateIconAndVolume();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseMusic(){
        musica.ToggleSound();
        UpdateIconAndVolume();
    }

    void UpdateIconAndVolume(){
        if(PlayerPrefs.GetInt("mute", 0) == 0){
            AudioListener.volume = 1;
            musicToggleButton.GetComponent<Image>().sprite = musicOnSprite;
        }else{
            AudioListener.volume = 0;
            musicToggleButton.GetComponent<Image>().sprite = musicOffSprite;
        }
    }
}
