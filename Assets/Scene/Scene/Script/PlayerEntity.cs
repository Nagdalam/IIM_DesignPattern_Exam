using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    [SerializeField] Health _health;

    public Health Health => _health;

    private void Awake()
    {
        _health.OnDeath += _health.Die;
        _health.OnInvincible += _health.InvincibilityToggle;
        //On inscrit ici les méthodes aux évènements voulus, uniquement pour le player
    }

    private void OnDestroy()
    {
        _health.OnDeath -= _health.Die;
        _health.OnInvincible -= _health.InvincibilityToggle;
        //On pense à désinscrire pour tout les évènements quand l'objet est détruit
    }

}


