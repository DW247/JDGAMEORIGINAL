using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogo2 : MonoBehaviour
{
    public AudioSource somJogo2;
    public AudioSource somJogo22;
    
    public void jogo2Jogo1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo1");
    }
    public void Tocar2()
    {
        somJogo2.Play();
    }
    public void Tocar22()
    {
        somJogo22.Play();
    }
}
