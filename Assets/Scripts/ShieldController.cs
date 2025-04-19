using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{

    public bool shieldState = false;

    private GameObject shield;

    // Start is called before the first frame update
    void Start()
    {
        shield = GameObject.Find("Shield capsule");
        shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "shield")
        {
            shieldState = true;
            shield.SetActive(true);
            Destroy(other.gameObject);
        }
    }

    public void DeactivateShield()
    {
        shieldState = false;
        shield.SetActive(false);
    }
}
