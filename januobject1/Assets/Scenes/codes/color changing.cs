using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    MeshRenderer m_Renderer;
    private Rigidbody rb;
    private void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_Renderer.material.color = Color.green;
        }

    }
}