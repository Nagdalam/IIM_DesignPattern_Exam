using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour, IPickUp
{
    public int _collLayer;
    public int PlayerLayer => _collLayer;
    [SerializeField] GameObject _gate;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == _collLayer)
        {
            _gate.SetActive(false);
            Destroy(gameObject);
        }
    }
}
