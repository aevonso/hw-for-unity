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
        Debug.Log("Остался голодный");
    }

    private void OnEnable()
    {
        //если 3 не хавал
        if (!GameObject.Find("Object3").GetComponent<HungerSystem>().hasEaten)
        {
            Debug.Log("Хочу есть");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
