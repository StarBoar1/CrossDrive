using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExoustSound : MonoBehaviour
{
    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().clip = clips [Random.Range(0, clips.Length)];
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
