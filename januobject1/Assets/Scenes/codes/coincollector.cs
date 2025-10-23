using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coincollector : MonoBehaviour
{
    // Start is called before the first frame update
    private int coinsCollected;
    [SerializeField] private TextMeshProUGUI scoreText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coins")
        {
            coinsCollected++;
            Destroy(other.gameObject);
            scoreText.text = coinsCollected.ToString();
        }
    }
}
