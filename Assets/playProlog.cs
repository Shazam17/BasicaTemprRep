using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playProlog : MonoBehaviour
{

    public enum LevelType
    {
        FIGURES,
        ANIMALS
    }

    public LevelType type;
    public AudioSource audioSource;
    AudioClip clip;
    // Start is called before the first frame update
    
    public void PlayProlog()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(clip);
        }
    }

    void Start()
    {
   
       audioSource = GetComponent<AudioSource>();
   
        var path = Hooks.GetVoicePath();

        if(type == LevelType.FIGURES)
        {
            AudioClip clip = Resources.Load<AudioClip>(path + "Фигуры/Уровень 1 пролог/поизучаем фигуры");
            audioSource.PlayOneShot(clip);
            this.clip = clip;
        }
        else if(type == LevelType.ANIMALS)
        {
            AudioClip clip = Resources.Load<AudioClip>(path + "Животные/Уровень 1 пролог/поизучаем животных");
            audioSource.PlayOneShot(clip);
            this.clip = clip;
        }
    }
}
