using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colliderZonaPermitida : MonoBehaviour
{
    public GameObject zonapermitidaobj;

    // Start is called before the first frame update
    void Start()
    {
        zonapermitidaobj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("ZonaPermitida"))
        {
            zonapermitidaobj.SetActive(true);
        }
        else
        if(other.gameObject.tag.Equals("podeandar"))
        {
            zonapermitidaobj.SetActive(false);
        }
    }
}
