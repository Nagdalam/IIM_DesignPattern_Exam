using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IHealth 
{
    int CurrentHealth { get; }
    int MaxHealth { get; }
    bool IsDead { get; }
    bool IsInvincible { get;}

    event UnityAction OnSpawn;
    event UnityAction<int> OnDamage;
    event UnityAction<int> OnHeal;
    event UnityAction OnDeath;
    event UnityAction<bool> OnInvincible;

    void TakeDamage(int amount);
    void HealDamage(int amount);
    void Die();
}
