using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, ITouchable
{
    [SerializeField] PotionPoolReference myPool;

    public void Touch(int power)
    {
        int chanceToSpawn = Random.Range(1, 5);
        if(chanceToSpawn == 4)
        {
            GameObject potion = myPool.Instance.GetPooledObject();
            potion.transform.position = transform.position;
            potion.SetActive(true);
        }
            Destroy(gameObject);
    }

}
