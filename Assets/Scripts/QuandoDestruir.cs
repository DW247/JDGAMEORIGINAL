using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuandoDestruir : MonoBehaviour
{
    public AudioSource DeadSong;
    // Start is called before the first frame update
    private void OnDestroy()
    {
        DeadSong.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
