using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem particleEffect;
    public Collider2D boardCollider;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.otherCollider == boardCollider && other.gameObject.CompareTag("Snow"))
        {
            particleEffect.Play();
        } 
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        particleEffect.Stop();
    }
}

