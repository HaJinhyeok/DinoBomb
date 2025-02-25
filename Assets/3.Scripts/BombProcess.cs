using UnityEngine;
using System.Collections.Generic;

public class BombProcess : MonoBehaviour
{
    public GameObject Bomb;
    public List<GameObject> BombList = new List<GameObject>();

    GameObject _bombPool;

    float _interval = 0.7f;
    float _coolTime = 0f;
    float _spawnPosY = 6f;

    void Start()
    {
        _bombPool = new GameObject("BombPool");
    }

    void Update()
    {
        _coolTime += Time.deltaTime;
        if (_coolTime > _interval)
        {
            _coolTime = 0f;
            SpawnBomb();
        }
    }

    void SpawnBomb()
    {
        for (int i = 0; i < BombList.Count; i++)
        {
            if (!BombList[i].activeSelf)
            {
                BombList[i].SetActive(true);
                BombList[i].transform.position =
                    new Vector3(Random.Range(-2f, 2f), _spawnPosY, 0);
                return;
            }
        }
        GameObject bomb = Instantiate(Bomb);
        bomb.transform.parent = _bombPool.transform;
        bomb.transform.position =
                    new Vector3(Random.Range(-2f, 2f), _spawnPosY, 0);
        BombList.Add(bomb);
    }
}
