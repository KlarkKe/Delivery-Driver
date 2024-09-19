using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool packageOn = false;
    [SerializeField] private float delayOfDestroy = 0.1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package" && !packageOn)
        {
            Debug.Log("Package picked up");
            packageOn = true;
            Destroy(collision.gameObject, delayOfDestroy);
        }

        if (collision.tag == "Customer" && packageOn)
        {
            Debug.Log("Package picked down");
            packageOn = false;
        }
    }
}