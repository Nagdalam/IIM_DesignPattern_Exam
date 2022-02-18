using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IPickUp
{
    void OnTriggerEnter2D(Collider2D collision);
    public int PlayerLayer { get; }
}
