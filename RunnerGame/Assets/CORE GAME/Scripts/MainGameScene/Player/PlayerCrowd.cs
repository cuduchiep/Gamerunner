using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerCrowd : MonoBehaviour
{
    [SerializeField] private int crowdSizeForDebug = 5;
    [SerializeField] private int startingCrowdSize = 1;

    [SerializeField] private PlayerShooter shooterPrefab;
    [SerializeField] private List<Transform> spawnPoints = new List<Transform>();
    private List<PlayerShooter> _shooters = new List<PlayerShooter>();
    public List<PlayerShooter> Shooters => _shooters;
    [ContextMenu("Set")]
    public void Debug_ResizeCrowd() => Set(crowdSizeForDebug);

    [SerializeField] private TMP_Text countApes;

    private int _count = 1;

    private void Start()
    {
        Set(startingCrowdSize);
        countApes.text = _count.ToString();
    }

    public void AddCountToCrowd(int crowdModifyAmount)
    {
        _count += crowdModifyAmount;
        countApes.text = _count.ToString();
    }
    public void AddCountToCrowd2(int crowdModifyAmount)
    {
        _count *= crowdModifyAmount;
        countApes.text = _count.ToString();
    }
    public void Set(int amount)
    {
        if (_shooters.Count == amount) return;
        var needToRemove = amount < _shooters.Count;
        var needToAdd = amount > _shooters.Count;
        while (amount != _shooters.Count)
        {
            if (needToRemove) RemoveShooter();
            else if (needToAdd) AddShooter();
        }
    }

    public bool CanAdd()
    {
        return _shooters.Count + 1 <= spawnPoints.Count;
    }

    public bool CanRemove()
    {
        return _shooters.Count - 2 >= 0;
    }
    public void RemoveShooter()
    {
        if (!CanRemove()) return;
        var lastShooter = _shooters[_shooters.Count - 1];
        _shooters.Remove(lastShooter);
        Destroy(lastShooter.gameObject);
    }

    public void AddShooter()
    {
        if (!CanAdd()) return;
        var lastShooterIndex = _shooters.Count - 1;
        var position = spawnPoints[lastShooterIndex + 1].position;
        var shooter = Instantiate(shooterPrefab, position, Quaternion.identity, transform);
        _shooters.Add(shooter);
    }
}
