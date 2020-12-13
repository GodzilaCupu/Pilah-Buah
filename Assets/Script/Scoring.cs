using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoring : MonoBehaviour
{
    public GameObject[] scoreText;
    public AudioSource audio;

    private void Update()
    {
        
    }

    void Level1()
    {
        if(scoreText[0] == true && scoreText[1] == true)
        {

        }
    }

    void OnTriggerEnter(Collider bentuk)
    {
        if(bentuk.CompareTag("Red"))
        {
            audio.Play();
            scoreText[0].SetActive(true);
            Destroy(GameObject.FindWithTag("Red"));
        }
        if (bentuk.CompareTag("pink"))
        {
            audio.Play();
            scoreText[1].SetActive(true);
            Destroy(GameObject.FindWithTag("pink"));
        }
        if (bentuk.CompareTag("green"))
        {
            audio.Play();
            scoreText[2].SetActive(true);
            Destroy(GameObject.FindWithTag("green"));
        }
    }
}
