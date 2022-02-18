using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXCreator : MonoBehaviour
{
    [SerializeField] GameObject _particleEffect;
    [SerializeField] ImpactHandler _impactHandler;

    private void Awake()
    {
        _impactHandler.OnImpact += CreateParticle;
    }

    private void OnDestroy()
    {
        _impactHandler.OnImpact -= CreateParticle;
    }

    public void CreateParticle(Vector3 position)
    {
        Instantiate(_particleEffect, position, Quaternion.identity);
    }
}
