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
        //On inscrit ici les m�thodes aux �v�nements voulus, uniquement pour le player
    }

    private void OnDestroy()
    {
        _health.OnDeath -= _health.Die;
        _health.OnInvincible -= _health.InvincibilityToggle;
        //On pense � d�sinscrire pour tout les �v�nements quand l'objet est d�truit
    }

}


