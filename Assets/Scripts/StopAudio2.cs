using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudio2 : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("music2");
        Destroy(A);
        //you're welcome
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
