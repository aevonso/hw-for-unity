using UnityEngine;

public class HungerSystem : MonoBehaviour
{

    public ObjectController objectController;
    public bool hasEaten = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (objectController == null)
            objectController = GameObject.Find("Object2").GetComponent<ObjectController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(objectController.foodValue > 20 && !hasEaten)
        {
            Debug.Log("� �������");
            hasEaten = true;

            //��� 4 ������� 
            GameObject.Find("Object4").GetComponent<HungerResponse>().OnThirdObjectAte();
        }
    }
}
