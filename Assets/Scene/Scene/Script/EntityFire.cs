using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFire : MonoBehaviour
{
    [SerializeField]PoolReference myPool;
    [SerializeField] Transform _spawnPoint;
    public void FireBullet(int power)
    {
        Bullet bullet = myPool.Instance.GetPooledObject();
        if(bullet != null)
        {
            bullet.transform.position = _spawnPoint.position;
            bullet.Init(_spawnPoint.TransformDirection(Vector3.right), power);
            bullet.gameObject.SetActive(true);
        }
      
    }

   

}
