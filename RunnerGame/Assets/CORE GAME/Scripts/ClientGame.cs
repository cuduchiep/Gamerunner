using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientGame : Singleton<ClientGame>
{
    public Sprite transparent;
    public List<Sprite> listSprites = new List<Sprite>();
    public List<int> prizes = new List<int>();
    public List<GameObject> prefabIdle = new List<GameObject>();
    public List<GameObject> prefabRunning = new List<GameObject>();
}
