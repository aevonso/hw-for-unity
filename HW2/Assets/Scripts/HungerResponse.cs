using UnityEngine;

public class HungerResponse : MonoBehaviour
{
    private HungerSystem thirdObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thirdObject = GameObject.Find("Object3")?.GetComponent<HungerSystem>();

    }

    public void OnThirdObjectAte()
    {
        Debug.Log("������� ��������");
    }

    private void OnEnable()
    {
        //���� 3 �� �����
        if (!GameObject.Find("Object3").GetComponent<HungerSystem>().hasEaten)
        {
            Debug.Log("���� ����");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
