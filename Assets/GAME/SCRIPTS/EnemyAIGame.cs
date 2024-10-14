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
 
            float aColorImg; 
        #endregion 
 
        #region UI 
 
        #endregion 
 
        #region BOOL 
            public bool isGoActiveBtn; 

            public bool goToPlayer; 

            public bool iSeePlayer;
            public bool iHearPlayer;

            public bool objIsDown;
        #endregion 
 
        #region GAME OBJECTS 
            public GameObject[] objTarget; 
 
            public Transform target; 
        #endregion 
         
        #region INT 
            public int numberTarget; 

            public int indexChase; // 0 - погоня не идет 1 - погоня идет 2 - ии идет за игроком 1 секунду
        #endregion 
 
        #region AI 
            public LayerMask layer; 
 
            private Camera _camera; 
 
            public float distance; 
        #endregion 
    #endregion 
 
    void Start() 
    { 
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); 
    } 
 
 
 
    void Update() 
    { 
        distanceToPlayer = Vector3.Distance(transform.position, Player.position); 

        //if(distanceToPlayer <= 15f && Player.GetComponent<PlayerMovementGAME>().onTheCarpet == false && Player.GetComponent<PlayerControllerMain>().inTheWardrobe == false && Player.GetComponent<PlayerMovementGAME>().isActiveAudio == false)
        //{
        //    target = Player; 
        //    goToPlayer = true;  
        //}
        //else
        //{
        //    if(!goToPlayer)
        //    {
        //        target = objTarget[numberTarget].transform; 
        //        goToPlayer = false; 
        //    }
        //}

        // если он видит игрока - идет за ним, если не видит его но слышит - идет за ним

        RaycastHit hit; 
        Ray ray = new Ray(transform.position, transform.forward); 

        Debug.DrawRay(transform.position, transform.forward, Color.green);
 
        if (Physics.Raycast(ray, out hit, distance, layer)) 
        { 
            
            #region ПРИСЛЕДОВАНИЕ И ОТСЛЕДОВАНИЕ С ИГРОКОМ 
 
            //if(!(hit.collider.tag == "stena"))
            //{
            //    if(hit.collider.tag == "Player") 
            //    { 
            //        iSeePlayer = true;
            //        target = Player; 
            //        goToPlayer = true; 
            //    } 
            //    else
            //    {
            //        iSeePlayer = false;
            //    }
            //}
            //else
            //{
            //    iSeePlayer = false;
            //}
            //if(!(hit.collider.tag == "Player"))
            //{ 
            //    if(distanceToPlayer > 15f)
            //    {
            //        target = objTarget[numberTarget].transform; 
            //        goToPlayer = false; 
            //    }
            //} // ЕСЛИ ПРОТИВНИК ВИДИТ ИГРОКА - ИДЕТ ЗА НИМ; ЕСЛИ ПРОТИВНИК НЕ ВИДИТ ИГРОКА НО СЛЫШИТ ЕГО - ИДЕТ ЗА НИМ; ЕСЛИ ПРОТИВНИК НЕ СЛЫШИТ И НЕ ВИДИТ ИГРОКА - ИДЕТ ПО СТОПАМ
                // ЕСЛИ ПРОТИВНИК СЛЫШИТ ИГРОКА - ИДЕТ ЗА НИМ; ЕСЛИ ПРОТИВНИК НЕ СЛЫШИТ ИГРОКА НО ВИДИТ ЕГО - ИДЕТ ЗА НИМ; ЕСЛИ ПРОТИВНИК НЕ СЛЫШИТ И НЕ ВИДИТ ИГРОКА - ИДЕТ ПО СТОПАМ
                // ЕСЛИ ПОГОНЯ ПЕРЕСТАЛА ИДТИ - ИИ ИДЕТ СЕКУНДУ ДО ИГРОКА;    
                // ПОЛУЧЕНИЕ 2 ИНДЕКСА ПОГОНИ - ЕСЛИ ПОГОНЯ 
                // 
            if(!(hit.collider.tag == "stena")) // смотрит не в стену
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
        Vector3 direction = target.position - transform.position; 
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up); 
        transform.rotation = Quaternion.Euler(0, rotation.eulerAngles.y, 0); 
        agent.SetDestination(target.position);  
        agent.speed = 2f; 
    } 
 
 
 
    #region VOID and IE 
        IEnumerator KDChase()
        {
            yield return new WaitForSeconds(1f);
        }
    #endregion 
}