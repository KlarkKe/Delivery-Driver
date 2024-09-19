using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        /*transform.Rotate(0, 0, -steerAmount);*/
        transform.Translate(0, moveAmount, 0);
        //условие для вращения объекта, при заднем ходе, как в реальной машине
        if (moveAmount > 0 || moveAmount == 0)
        {
            transform.Rotate(0, 0, -steerAmount);
        }
        else
        {
            transform.Rotate(0, 0, steerAmount);
        }
    }
}