using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogo1 : MonoBehaviour
{
    public AudioSource somJogo1;
    public void jogo1Jogo2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo2");
    }
    public void jogo1Jogo3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo3");
    }
    public void Tocar1()
    {
        somJogo1.Play();
    }
}
