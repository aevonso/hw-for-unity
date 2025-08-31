using UnityEngine;

public class ObjectController : MonoBehaviour
{

    public GameObject firstObject;
    public GameObject secondObject;
    public int foodValue = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (firstObject == null)
            firstObject = GameObject.Find("Object1");
        if (secondObject == null)
            secondObject = GameObject.Find("Object2");
    }

    // Update is called once per frame
    void Update()
    {
        if(firstObject.activeSelf)
        {
            secondObject.SetActive(false);
        }
        else
        {
            secondObject.SetActive(true);
        }
        //если второй включен и еда > 20

        if(secondObject.activeSelf && foodValue >20)
        {
            Debug.Log("Я похавал");
        }
    }
}
