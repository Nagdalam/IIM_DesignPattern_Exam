using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    [SerializeField] AudioSource myAudioSource;
    [SerializeField] AudioClip bulletClip;
    [SerializeField] ImpactHandler _impactHandler;

    private void Awake()
    {
        _impactHandler.OnImpact += PlaySoundAtLocation;
    }

    private void OnDestroy()
    {
        _impactHandler.OnImpact -= PlaySoundAtLocation;
    }

   public void PlaySoundAtLocation(Vector3 location)
    {
        AudioSource.PlayClipAtPoint(bulletClip, location);
    }

}
