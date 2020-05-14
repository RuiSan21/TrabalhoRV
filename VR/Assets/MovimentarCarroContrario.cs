using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentarCarroContrario : MonoBehaviour
{
    public Transform[] caminhoArray;
    public bool pararCorrida = false;
    public float distanciaParaMudarCaminho = 0.01f;
    public float velocidade = 5;
    public Animator animator;



    private GameObject wayPoint;
    private Vector3 wayPointPos;


    IEnumerator CorridaRobot()
    {
        int indiceCaminho = 0;
        Vector3 posicaoRobot = gameObject.transform.position;
        float tempo = 0;

        yield return new WaitForSeconds(1f);

        while (pararCorrida == false)
        {
            if (Vector3.Distance(gameObject.transform.position, caminhoArray[indiceCaminho].position) < distanciaParaMudarCaminho)
            {
                indiceCaminho = (indiceCaminho + 1) % caminhoArray.Length;
                gameObject.transform.Rotate(0.0f, 45.0f, 0.0f, Space.Self);
                posicaoRobot = gameObject.transform.position;
                tempo = 0;
                gameObject.transform.Rotate(0.0f, 45.0f, 0.0f, Space.Self);
            }
            else
            {
                gameObject.transform.position = Vector3.Lerp(posicaoRobot, caminhoArray[indiceCaminho].position, tempo);
                tempo = tempo + Time.deltaTime / velocidade;
            }
            yield return null;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CorridaRobot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
