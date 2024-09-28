using UnityEngine;

public class CollisionLogic : MonoBehaviour
{
    
    // Check for Collision with GameObject with Name "Coin" and hide the Coins
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Coin")
        {
            collision.gameObject.SetActive(false);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
