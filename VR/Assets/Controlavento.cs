using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlavento : MonoBehaviour
{
    public Text vento;
    private int ventania;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       if(transform.position.z < 45.5)
        {
            ventania = 0;
            vento.text = ventania.ToString();
        }
        else {

            //vento

            if ( transform.position.y < 30)
            {
                ventania = 0;
                vento.text = ventania.ToString();
            }
            if (transform.position.y > 30 && transform.position.y < 70)
        {
            ventania = 10;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 70 && transform.position.y < 90)
        {
            ventania = 20;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 90 && transform.position.y < 140)
        {
            ventania = 30;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 140 && transform.position.y < 180)
        {
            ventania = 40;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 180 && transform.position.y < 200)
        {
            ventania = 50;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 200 && transform.position.y < 230)
        {
            ventania = 60;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 230 && transform.position.y < 250)
        {
            ventania = 70;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 230 && transform.position.y < 250)
        {
            ventania = 80;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 250 && transform.position.y < 266)
        {
            ventania = 90;
            vento.text = ventania.ToString();
        }

        if (transform.position.y > 266)
        {
            ventania = 100;
            vento.text = ventania.ToString();
        }

        }



        //

    }
}
