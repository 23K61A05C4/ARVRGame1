using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    [SerializeField] private float movespeed;
    public AudioSource coinSound;
    private void Update()
    {
        movement();
    }
    void movement()
    {
        float xvalue = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float zvalue = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Translate(xvalue, 0, zvalue);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coins"))
        {
            coinSound.Play();
        }
        Destroy(coinSound);
    }
}
