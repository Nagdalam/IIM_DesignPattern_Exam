using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthProxy : MonoBehaviour, IHealth
{
    [SerializeField] Health _health;

    public int CurrentHealth => _health.CurrentHealth;

    public int MaxHealth => _health.MaxHealth;

    public bool IsInvincible => _health.IsInvincible;

    public bool IsDead => _health.IsDead;

    public event UnityAction OnSpawn
    {
        add => _health.OnSpawn += value;
        remove => _health.OnSpawn -= value;
    }
    public event UnityAction<int> OnDamage
    {
        add => _health.OnDamage += value;
        remove => _health.OnDamage -= value;
    }
    public event UnityAction<int> OnHeal
    {
        add => _health.OnDamage += value;
        remove => _health.OnDamage -= value;
    }
    public event UnityAction OnDeath
    {
        add => _health.OnDeath += value;
        remove => _health.OnDeath -= value;
    }

    public event UnityAction<bool> OnInvincible
    {
        add => _health.OnInvincible += value;
        remove => _health.OnInvincible -= value;
    }

    public void TakeDamage(int amount) => _health.TakeDamage(amount);
    public void HealDamage(int amount) => _health.HealDamage(amount);
    public void Die() => _health.Die();

    public void InvincibilityToggle(bool shouldTurnOn) => _health.InvincibilityToggle(shouldTurnOn);


}
