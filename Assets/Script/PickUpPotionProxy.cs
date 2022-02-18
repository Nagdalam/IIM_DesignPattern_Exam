using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickUpPotionProxy : MonoBehaviour, IPickUp
{
    [SerializeField] PickUpPotion _potion;
    public int PlayerLayer => _potion._collLayer;

    public void OnTriggerEnter2D(Collider2D collision) => _potion.OnTriggerEnter2D(collision);
}
