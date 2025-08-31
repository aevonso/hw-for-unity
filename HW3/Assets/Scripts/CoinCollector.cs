using System;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{

    public float collectionDistance = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CollectCoins();
    }

    private void CollectCoins()
    {
        Coin[] coins = FindObjectsOfType<Coin>();

        foreach (Coin coin in coins)
        {
            float distance = Vector3.Distance(transform.position, coin.transform.position);

            if (distance <= collectionDistance)
            {
                GameManager.instance.CollectionCoin(coin.value);
                Destroy(coin.gameObject);
            }
        }
    }
}
