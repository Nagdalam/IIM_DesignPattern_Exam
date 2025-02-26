using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour, IHealth
{
    // Champs
    [SerializeField] int _startHealth;
    [SerializeField] int _maxHealth;
    [SerializeField] UnityEvent _onDeath;
    public UnityEvent _onHeal;
    [SerializeField] UnityEvent _onInvincible;
    bool _isInvincible;
    [SerializeField] ControlShakeReference _shakeRef;

    // Propriétés
    public int CurrentHealth { get; private set; }
    public int MaxHealth => _maxHealth;
    public bool IsDead => CurrentHealth <= 0;
    public bool IsInvincible => _isInvincible;

    // Events
    public event UnityAction OnSpawn;
    public event UnityAction<int> OnDamage;
    public event UnityAction<int> OnHeal;
    public event UnityAction<bool> OnInvincible;
    public event UnityAction OnDeath { add => _onDeath.AddListener(value); remove => _onDeath.RemoveListener(value); }

    // Methods
    void Awake() => Init();

    void Init()
    {
        CurrentHealth = _startHealth;
        OnSpawn?.Invoke();
    }


    public void TakeDamage(int amount)
    {
        if (!_isInvincible) { 
        if (amount < 0) throw new ArgumentException($"Argument amount {nameof(amount)} is negativ");

            _shakeRef.Instance.LaunchScreenShake();
        var tmp = CurrentHealth;
        CurrentHealth = Mathf.Max(0, CurrentHealth - amount);
        var delta = CurrentHealth - tmp;
        OnDamage?.Invoke(delta);

        if(CurrentHealth <= 0)
        {
            _onDeath?.Invoke();
        }
        }
    }

    public void HealDamage(int amount)
    {
        if (amount < 0) throw new ArgumentException($"Argument amount {nameof(amount)} is negativ");
        CurrentHealth += amount;
        OnHeal.Invoke(amount);
        if (CurrentHealth < MaxHealth)
            CurrentHealth = MaxHealth;
    }

    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void SetInvincibility(bool shouldTurnOn)
    {
        OnInvincible.Invoke(shouldTurnOn);
    }
    public void InvincibilityToggle(bool shouldTurnOn)
    {
        _isInvincible = shouldTurnOn;
    }

    [Button("test")]
    void MaFonction()
    {
        var enumerator = MesIntPrefere();

        while(enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current);
        }
    }


    List<IEnumerator> _coroutines;

    IEnumerator<int> MesIntPrefere()
    {

        //

        var age = 12;

        yield return 12;


        //

        yield return 3712;

        age++;
        //

        yield return 0;



        //
        yield break;
    }





}
