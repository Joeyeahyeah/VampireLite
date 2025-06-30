using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Health health;

    public void Update()
    {
        healthBar.value = health.Value;
    }

    private void Awake()
    {
        healthBar.maxValue = health.Value;
        healthBar.value = health.Value;
    }
}