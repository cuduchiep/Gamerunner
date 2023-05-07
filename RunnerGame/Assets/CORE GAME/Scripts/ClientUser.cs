using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientUser : Singleton<ClientUser>
{
    [Header("Coin")]
    public int amountCoin;

    [Header("Monkey")]
    public List<int> monkeyHas = new List<int>();

}
