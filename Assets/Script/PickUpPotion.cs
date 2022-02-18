using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickUpPotion : MonoBehaviour, IPickUp
{
    public int _collLayer;

    public int PlayerLayer => _collLayer;
    [SerializeField] int _healAmount;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == _collLayer)
        {
            collision.GetComponentInParent<IHealth>()?.HealDamage(_healAmount);
            gameObject.SetActive(false);
        }
    }
}
