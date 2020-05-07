using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentarRobot : MonoBehaviour
{
    public Transform[] caminhoArray;
    public bool pararCorrida = false;
    public float distanciaParaMudarCaminho = 0.01f;
    public float velocidade = 5;
    public Animator animator;



    private GameObject wayPoint;
    private Vector3 wayPointPos;
   
    //This will be the zombie's speed. Adjust as necessary.
    private float speed = 4f;

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
                gameObject.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
                posicaoRobot = gameObject.transform.position;
                tempo = 0;
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
        animator = GetComponent<Animator>();


        //At the start of the game, the zombies will find the gameobject called wayPoint.
        //wayPoint = GameObject.Find("wayPoint");



    }

    // Update is called once per frame
    void Update()
    {
       
        animator = GetComponent<Animator>();
        animator.SetBool("Walk", true);
        animator.SetBool("SprintJump", false);
        animator.SetBool("SprintSlide", false);



        wayPointPos = new Vector3(wayPoint.transform.position.x+2, 0.6f, wayPoint.transform.position.z+2);
        //Here, the zombie's will follow the waypoint.
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    }

    void OnDestroy()
    {
        pararCorrida = true;
    }
}
