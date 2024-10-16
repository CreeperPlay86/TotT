using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyAIGame : MonoBehaviour 
{ 
    #region DATA 
        #region NAV MESH 
            private UnityEngine.AI.NavMeshAgent agent; 
        #endregion 
 
        #region TRANSFORMS 
            public Transform Player; 
        #endregion 
         
        #region FLOAT 
            public float distanceToPlayer; 

            public float rotationY;
        #endregion 
 
        #region BOOL 
            public bool isGoActiveBtn; 

            public bool goToPlayer; 

            public bool iSeePlayer;
            public bool iHearPlayer;

            public bool objIsDown;

            public bool isInspection;

            public bool isScreamer;

            public bool takePicture;
        #endregion 
 
        #region GAME OBJECTS 
            public GameObject[] objTarget; 
 
            public Transform target; 

            public GameObject animationWalk;
            public GameObject animationStun;
            public GameObject animationIdle;
            public GameObject animationScreamer;

            public GameObject screamerCamera;

            #region AUDIO
                public GameObject audioScreamer;
            #endregion
        #endregion 
         
        #region INT 
            public int numberTarget; 

            public int indexChase; // 0 - погоня не идет 1 - погоня идет 2 - ии идет за игроком 1 секунду
        #endregion 
 
        #region AI 
            public LayerMask layer; 
 
            private Camera _camera; 
 
            public float distance; 

            // включается вспышка - появляется скин стана после чего на пару секунд появляется скин ходьбы и енеми ускоряется в 2 раза на 10 секунд
        #endregion 

        #region CONNECT
            public GameObject graphics;
        #endregion
    #endregion 
 
    void Start() 
    { 
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); 
    } 
 
 
 
    void Update() 
    { 
        distanceToPlayer = Vector3.Distance(transform.position, Player.position); 

        // если он видит игрока - идет за ним, если не видит его но слышит - идет за ним

        RaycastHit hit; 
        Ray ray = new Ray(transform.position, transform.forward); 

        Debug.DrawRay(transform.position, transform.forward, Color.green);
 
        if (Physics.Raycast(ray, out hit, distance, layer)) 
        { 
            
            #region ПРИСЛЕДОВАНИЕ И ОТСЛЕДОВАНИЕ С ИГРОКОМ 
 
                // ЕСЛИ ПРОТИВНИК ВИДИТ ИГРОКА - ИДЕТ ЗА НИМ; ЕСЛИ ПРОТИВНИК НЕ ВИДИТ ИГРОКА НО СЛЫШИТ ЕГО - ИДЕТ ЗА НИМ; ЕСЛИ ПРОТИВНИК НЕ СЛЫШИТ И НЕ ВИДИТ ИГРОКА - ИДЕТ ПО СТОПАМ
                // ЕСЛИ ПРОТИВНИК СЛЫШИТ ИГРОКА - ИДЕТ ЗА НИМ; ЕСЛИ ПРОТИВНИК НЕ СЛЫШИТ ИГРОКА НО ВИДИТ ЕГО - ИДЕТ ЗА НИМ; ЕСЛИ ПРОТИВНИК НЕ СЛЫШИТ И НЕ ВИДИТ ИГРОКА - ИДЕТ ПО СТОПАМ
                // ЕСЛИ ПОГОНЯ ПЕРЕСТАЛА ИДТИ - ИИ ИДЕТ СЕКУНДУ ДО ИГРОКА;    
                // ПОЛУЧЕНИЕ 2 ИНДЕКСА ПОГОНИ - ЕСЛИ ПОГОНЯ 
                // 
            if(!(hit.collider.tag == "stena" || hit.collider.tag == "door")) // смотрит не в стену
            {
                if(hit.collider.tag == "Player") 
                { 
                    iSeePlayer = true; 
                    target = Player; // ИИ ВИДИТ ИГРОКА - ИДЕТ ЗА НИМ
                    indexChase = 1;
                }
                else // ИИ НЕ ВИДИТ ИГРОКА
                {
                    iSeePlayer = false;
                    if(distanceToPlayer <= 15f && Player.GetComponent<PlayerMovementGAME>().onTheCarpet == false && Player.GetComponent<PlayerControllerMain>().inTheWardrobe == false && Player.GetComponent<PlayerMovementGAME>().isActiveAudio == true) // ЕСЛИ ПРОТИВНИК НЕ ВИДИТ ИГРОКА НО СЛЫШИТ ЕГО - ИДЕТ ЗА НИМ;
                    {
                        target = Player;
                        indexChase = 1;
                    }
                    if(distanceToPlayer > 15f || Player.GetComponent<PlayerMovementGAME>().onTheCarpet == true || Player.GetComponent<PlayerControllerMain>().inTheWardrobe == true || Player.GetComponent<PlayerMovementGAME>().isActiveAudio == false) // ИИ НЕ СЛЫШИТ ИГРОКА
                    {
                        if(!objIsDown)
                        {
                            target = objTarget[numberTarget].transform; 
                            indexChase = 0;
                        }
                    }
                }
            }
            else // смотрит в стену
            {
                iSeePlayer = false;
                if(distanceToPlayer <= 15f && Player.GetComponent<PlayerMovementGAME>().onTheCarpet == false && Player.GetComponent<PlayerControllerMain>().inTheWardrobe == false && Player.GetComponent<PlayerMovementGAME>().isActiveAudio == true) // ЕСЛИ ПРОТИВНИК НЕ ВИДИТ ИГРОКА НО СЛЫШИТ ЕГО - ИДЕТ ЗА НИМ;
                {
                    target = Player;
                    indexChase = 1;
                }
                if(distanceToPlayer > 15f || Player.GetComponent<PlayerMovementGAME>().onTheCarpet == true || Player.GetComponent<PlayerControllerMain>().inTheWardrobe == true || Player.GetComponent<PlayerMovementGAME>().isActiveAudio == false) // ИИ НЕ СЛЫШИТ ИГРОКА
                {
                    if(!objIsDown)
                    {
                        target = objTarget[numberTarget].transform; 
                        indexChase = 0;
                    }
                }
            }            
            #endregion 
        } 

        if(indexChase == 0)
        {
            if(!objIsDown)
            {
                target = objTarget[numberTarget].transform; 
                indexChase = 0;
            }
        }

        if(!isInspection)
        {
            Vector3 direction = target.position - transform.position; 
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up); 
            transform.rotation = Quaternion.Euler(0, rotation.eulerAngles.y, 0);
            if(!isScreamer && !takePicture)
                agent.speed = 1f;
        }

        agent.SetDestination(target.position);  

        if(!isScreamer && !takePicture)
        {
            if(!isInspection)
                agent.speed = 1f;
            else
                agent.speed = 0f;
        }
    } 

    void FixedUpdate()
    {
        #region ОСМОТР ПРИ ПАТРУЛИРОВАНИИ
        if(isInspection)
        {
            if(iSeePlayer)
            {
                agent.speed = 1f;
                isInspection = false;
            }
            agent.speed = 0f;
            rotationY += (Time.deltaTime * 60f);
            transform.rotation = Quaternion.Euler(transform.rotation.x, rotationY,transform.rotation.z);
            if(!takePicture)
            {
                animationWalk.SetActive(false);
                animationIdle.SetActive(true);
                animationStun.SetActive(false);
            }
            else
            {
                animationWalk.SetActive(false);
                animationIdle.SetActive(false);
                animationStun.SetActive(true);
            }
            StartCoroutine(OffIsInspection());
        }
        #endregion
    }
 
 
 
    #region VOID and IE 
        IEnumerator KDChase()
        {
            yield return new WaitForSeconds(1f);
        }

        IEnumerator spawnEnemy()
        {
            yield return new WaitForSeconds(3);
            agent.speed = 1f;
            isScreamer = false;
        }

        IEnumerator OffIsInspection()
        {
            yield return new WaitForSeconds(5);
            isInspection = false;
            animationWalk.SetActive(true);
            animationIdle.SetActive(false);
            rotationY = 0;
        }

        private void OnTriggerEnter(Collider a)
        {
            if(a.gameObject.tag == "playerTrigger")
            {
                #region SCREAMER
                    Instantiate(audioScreamer);
                    Player.GetComponent<PlayerControllerMain>().health--;
                        StartCoroutine(spawnEnemy());
                        transform.position = new Vector3(-0.24f, 1.042f, -0.157f);
                        agent.speed = 0f; 
                        screamerCamera.SetActive(true);
                #endregion
            }
        }

        public void agentSpedZero()
        {
            agent.speed = 0f; 
        }

        public void agentSpedDefault()
        {
            agent.speed = 1f; 
        }
    #endregion 
}