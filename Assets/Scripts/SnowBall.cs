using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{

    [SerializeField] private GameObject toucheTexte;

    void Start()
    {
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bonhomme de neige")
        {
            toucheTexte.gameObject.SetActive(true);
            GameObject.Find("Audio Manager").GetComponent<AudioManager>().Crie();
        }

        Destroy(gameObject);
    }


    void Update()
    {
        
    }
}
