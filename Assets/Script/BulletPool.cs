using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    private List<Bullet> _bulletsPooled = new List<Bullet>();
    [SerializeField] int _amountToPool;
    [SerializeField] Bullet _bulletPrefab;
    [SerializeField] PoolReference _poolRef;

    private void Start()
    {
        (_poolRef as IReferenceSetter<BulletPool>).SetInstance(this);
        for (int i = 0; i < _amountToPool; i++)
        {
            var _bullet = Instantiate(_bulletPrefab);
            _bullet.gameObject.SetActive(false);
            _bulletsPooled.Add(_bullet);
        }
    }

    public Bullet GetPooledObject()
    {
        for (int i = 0; i < _bulletsPooled.Count; i++)
        {
            if (!_bulletsPooled[i].gameObject.activeInHierarchy)
            {
                return _bulletsPooled[i];
            }
        }
        return null;
    }
}
