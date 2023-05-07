using System;
using UnityEngine;
public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private float defaultShootDelay = 1f;
    [SerializeField] private float damagePerShootable = 100f;
    [SerializeField] private Transform shootFrom;
    [SerializeField] private float damageAddPerYear = 2f;
    private float _shootDelay;
    private float _runningTimer;


    private void Start()
    {
        _shootDelay = defaultShootDelay;

    }

    private void Update()
    {
        _runningTimer += Time.deltaTime;
        if (_runningTimer >= _shootDelay)
        {
            _runningTimer = 0f;

        }
    }
} 
