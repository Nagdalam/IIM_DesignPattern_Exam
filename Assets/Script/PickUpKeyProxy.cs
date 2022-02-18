using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKeyProxy : MonoBehaviour
{
    [SerializeField] PickUpKey _key;
    public int PlayerLayer => _key._collLayer;

    public void OnTriggerEnter2D(Collider2D collision) => _key.OnTriggerEnter2D(collision);
}
