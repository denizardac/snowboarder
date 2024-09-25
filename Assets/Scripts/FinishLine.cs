using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float FinishReloadTime = 1f;
    [SerializeField] ParticleSystem particleEffect;

    bool hasPlayed = false;
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Player")
        {
            particleEffect.Play();
            if( hasPlayed == false )
            {
                GetComponent<AudioSource>().Play();
                hasPlayed = true;
            }
            Invoke("ReloadScene", FinishReloadTime);
        }
    }
    private void ReloadScene () 
    {
        SceneManager.LoadScene(0);
    }
}
