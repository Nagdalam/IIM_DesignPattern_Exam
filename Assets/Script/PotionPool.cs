using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionPool : MonoBehaviour
{
    private List<GameObject> _potionsPooled = new List<GameObject>();
    [SerializeField] int _amountToPool;
    [SerializeField] GameObject _potionPrefab;
    [SerializeField] PotionPoolReference _poolRef;

    private void Start()
    {
        (_poolRef as IReferenceSetter<PotionPool>).SetInstance(this);
        for (int i = 0; i < _amountToPool; i++)
        {
            var _bullet = Instantiate(_potionPrefab);
            _bullet.gameObject.SetActive(false);
            _potionsPooled.Add(_bullet);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < _potionsPooled.Count; i++)
        {
            if (!_potionsPooled[i].gameObject.activeInHierarchy)
            {
                return _potionsPooled[i];
            }
        }
        return null;
    }
}
