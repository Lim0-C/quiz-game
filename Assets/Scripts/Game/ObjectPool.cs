using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int poolSize;
    
    private Queue<GameObject> _pool;
    private static ObjectPool _instance;

    public static ObjectPool Instance
    {
        get{ return _instance; }
    }

    private void Awake()
    {
        _instance = this;
        _pool = new Queue<GameObject>();
        
    }

    private void CreatNewObject()
    {
        GameObject newObject = Instantiate(prefab);
        newObject.SetActive(false);
        _pool.Enqueue(newObject);
    }

    public GameObject GetObject()
    {
        if (_pool.Count == 0)
        {
            CreatNewObject();
        }
        GameObject card = _pool.Dequeue();
        card.SetActive(true);
        return card;
    }

    public void ReturnObject(GameObject returnObject)
    {
        returnObject.SetActive(false);
        _pool.Enqueue(returnObject);
    }
}
