using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ImpactHandler : MonoBehaviour
{
    [SerializeField] ImpactReference _impactRef;
    public event UnityAction<Vector3> OnImpact;

    void Start()
    {
        (_impactRef as IReferenceSetter<ImpactHandler>).SetInstance(this);
    }

    public void TriggerImpact(Vector3 position)
    {
        OnImpact.Invoke(position);
    }
}
