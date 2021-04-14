using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private AudioSource _audioSource;


    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponentInChildren<AudioSource>();
        _audioSource.Play();
    }

    private void Start()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Stop();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
