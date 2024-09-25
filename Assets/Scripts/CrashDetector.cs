using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float HeadReloadTime = 1f;
    [SerializeField] ParticleSystem particleEffect;
    [SerializeField] AudioClip crashEffect;

    public Collider2D headCollider;

    private void OnCollisionEnter2D(Collision2D other) 
    {
    if (other.otherCollider == headCollider && other.gameObject.CompareTag("Snow")) 
        {
            FindObjectOfType<Player>().disableControls();
            particleEffect.Play();
            GetComponent<AudioSource> ().PlayOneShot(crashEffect);
            Invoke("ReloadScene", HeadReloadTime);
        }
    }
    private void ReloadScene () 
    {
        SceneManager.LoadScene(0);
    }
}
