using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource trilhaJogo;
    public static GameManager gameManager;
    private void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
        }
        else if(gameManager != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (!trilhaJogo.isPlaying)
            {
                trilhaJogo.Play();
            }

        }
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (trilhaJogo.isPlaying)
            {
                trilhaJogo.Stop();
            }

        }
    }
  
    
}
