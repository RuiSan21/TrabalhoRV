using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class informacaoExperiencia : MonoBehaviour
{
    public GameObject informacaoExp;

    // Start is called before the first frame update
    void Start()
    {
        informacaoExp.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            informacaoExp.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            informacaoExp.SetActive(true);
        }
    }
}
