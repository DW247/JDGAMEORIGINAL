using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuandoDestruir : MonoBehaviour
{
    public AudioClip audioclip;
    
    // Start is called before the first frame update
    private void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(audioclip, Camera.main.transform.position);
    }



}
