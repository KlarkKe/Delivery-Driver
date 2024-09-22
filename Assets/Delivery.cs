using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    bool packageOn = false;
    [SerializeField] private float delayOfDestroy = 0.1f;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package" && !packageOn)
        {
            Debug.Log("Package picked up");
            packageOn = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, delayOfDestroy);
        }

        if (collision.tag == "Customer" && packageOn)
        {
            Debug.Log("Package picked down");
            spriteRenderer.color = noPackageColor;
            packageOn = false;
        }
    }
}