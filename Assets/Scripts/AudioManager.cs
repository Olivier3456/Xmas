using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourceBienvenue;
    [SerializeField] private AudioSource audioSourceMusique;
    [SerializeField] private AudioSource audioSourceCri;
    
    [SerializeField] private AudioClip musique;
    [SerializeField] private AudioClip bienvenue;
    [SerializeField] private AudioClip cri;
   
    
    void Start()
    {
        audioSourceMusique.clip = musique;
        audioSourceBienvenue.clip = bienvenue;
        audioSourceCri.clip = cri;
        
     
        audioSourceMusique.Play();
        audioSourceBienvenue.Play();
    }

    private void Update()
    {
        if (!audioSourceBienvenue.isPlaying && audioSourceMusique.volume < 0.8f)
        {
            audioSourceMusique.volume += Time.deltaTime / 2;    // Augmente le volume peu à peu après le son de bienvenue.
        }
    }

    public void Crie()
    {
        audioSourceCri.Play();
    }
}
