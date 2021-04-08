using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    //how many pages collected
    static int numberofpages = 0;

    public GameObject won;

    public AudioSource pagesound;

    private void Start()
    {
        //implementation of pages number at the beginning of the game
        numberofpages = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        //play sound and add page to collection
        pagesound.Play();
        numberofpages++;

        if(numberofpages == 4)
        {
            won.SetActive(true);
        }
       
        Destroy(gameObject);
    }
}
