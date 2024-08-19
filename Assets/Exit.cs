using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public string sceneToLoad;
    public float waitTime;
    public AudioSource exitSound;
    public Animator Fade;
    [SerializeField] GameObject crossfade;



    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  crossfade.SetActive(true);
        
        Invoke("LoadNextLevel", waitTime);
       // Fade.SetTrigger("StartFade");

    }

    

    void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }


}
