using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int totalScore = 0;
    private Dictionary <int, int> coinsCollected = new Dictionary<int, int>();

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectionCoin(int value)
    {
        totalScore += value;

        //intive dictinary
        if(coinsCollected.ContainsKey(value))
        {
            coinsCollected[value]++;
        }
        else
        {
            coinsCollected.Add(value, 1);
        }

        Debug.Log($"�� ������� {totalScore} �����");

        CheckVictory();
    }

    void CheckVictory()
    {
        Coin[] remainingCoins = FindObjectsOfType<Coin>();
        if ( remainingCoins.Length == 0 )
        {
            Debug.Log("������!");
            ShowResults();
        }
    }

    void ShowResults()
    {
        Debug.Log("�� �������: ");

        foreach(var coin in coinsCollected)
        {
            string coinWord = GetCoinWord(coin.Value);
            Debug.Log($"Coin {coinWord} ���������� {coin.Key}");
        }
    }

    string GetCoinWord(int count)
    {
        if(count%10 == 1 && count % 100 != 11)
        {
            return "������";
        }
        if (count % 10 >= 2 && count % 10 <= 4 && (count % 100 < 10 || count % 100 >= 20))
        {
            return "������";
        }
        return "�����";
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
