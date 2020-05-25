using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class animalBatch : MonoBehaviour
{

    public Text text;
    public AudioClip clip;
    public AudioClip ch;
    public AudioClip animalSound;

    public AudioSource audioSource;

    void Start()
    {
        StartCoroutine(lockProlog());
    }

    public void Play()
    {
        audioSource.Stop();
            audioSource.PlayOneShot(clip);
            StartCoroutine(PlayAnimalSound());
        

    }
    public void PlayChild()
    {
        audioSource.Stop();

        audioSource.PlayOneShot(ch);
            StartCoroutine(PlayAnimalSound());

    }

    public IEnumerator PlayAnimalSound()
    {
        yield return new WaitForSeconds(1.5f);
        audioSource.PlayOneShot(animalSound);
    }

    public bool lck = false;
    public IEnumerator lockProlog()
    {
        lck = true;
        yield return new WaitForSeconds(3.0f);
        lck = false;
    }
}
