using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IShootable
{
    void OnTriggerEnter2D(Collider2D collision);
    public int WantedLayerID { get; }
}
