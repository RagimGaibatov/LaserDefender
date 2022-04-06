using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")] [SerializeField] private AudioClip shootingClip;
    [SerializeField] [Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Wounding")] [SerializeField] private AudioClip woundingClip;
    [SerializeField] [Range(0f, 1f)] private float woundingPlayerVolume = 1f;
    [SerializeField] [Range(0f, 1f)] private float woundingEnemyVolume = 1f;

    private static AudioPlayer instance;

    private void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayWoundingClip(bool a)
    {
        if (woundingClip != null)
        {
            if (a == true)
            {
                AudioSource.PlayClipAtPoint(woundingClip, Camera.main.transform.position, woundingPlayerVolume);
            }

            if (a == false)
            {
                AudioSource.PlayClipAtPoint(woundingClip, Camera.main.transform.position, woundingEnemyVolume);
            }
        }
    }

    public void PlayShootingClip()
    {
        if (shootingClip != null)
        {
            AudioSource.PlayClipAtPoint(shootingClip, Camera.main.transform.position, shootingVolume);
        }
    }
}