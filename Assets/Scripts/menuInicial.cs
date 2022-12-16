using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    public AudioSource somTecla;        
    public void CenaJogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo1");
    }
    public void SairJogo()
    {
        Application.Quit();
    }
    public void Tocar()
    {
        somTecla.Play();
    }
}
