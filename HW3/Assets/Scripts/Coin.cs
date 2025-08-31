using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    public float rotationSpeed = 100f;
    void Start()
    {
        
    }

    //вращение монетк
    void Update()
    {
        transform.Rotate(Vector3.up *rotationSpeed *  Time.deltaTime);
    }
}
