using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [Header("In Game")]
    public AudioClip background;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
