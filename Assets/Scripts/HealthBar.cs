using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Slider _healthbar;

    private void Start()
    {
        var player = _player.GetComponent<Player>();
        _healthbar.maxValue = player.MaxHealth;
        _healthbar.value = player.GetComponent<Player>().CurrentHealth;
    }
}
