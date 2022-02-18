using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifebar : MonoBehaviour
{
    public Health _health;
    public Slider healthSlider;

    private void Awake()
    {
        healthSlider.maxValue = _health.MaxHealth;
        healthSlider.value = _health.MaxHealth;
        _health.OnDamage += UpdateLifeBar;
        _health.OnHeal += UpdateLifeBar;
    }

    private void OnDestroy()
    {
        _health.OnDamage -= UpdateLifeBar;
        _health.OnHeal -= UpdateLifeBar;
    }
    void UpdateLifeBar(int life)
    {
        healthSlider.value = healthSlider.value+life;
    }
}
