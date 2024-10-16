using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoApparat : MonoBehaviour
{
    #region DATA
        #region GAME OBJECTS and TRANSFORN||VECTOR
            public GameObject light;

            public GameObject enemy;

            public GameObject animationStunEnemy;
            public GameObject animationWalkEnemy;

            public GameObject audioTakeFoto;
        #endregion

        #region FLOAT
            public float distanceToEnemy;
        #endregion

        #region BOOL
            public bool goPicture;
        #endregion
    #endregion



    void Start()
    {
        goPicture = true;
    }


    
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(goPicture)
            {
                StartCoroutine(doPicture());
                goPicture = false;

                #region СОЗДАНИЕ ЗВУКА
                    Instantiate(audioTakeFoto);
                    enemy.GetComponent<EnemyAIGame>().target = enemy.GetComponent<EnemyAIGame>().Player;
                #endregion      
            }
        }
    }



    #region VOID and IEnumerator
        IEnumerator doPicture()
        {
            if(enemy.GetComponent<EnemyAIGame>().isScreamer == false)
            {
                #region ENEMY
                    enemy.GetComponent<EnemyAIGame>().takePicture = true;
                    animationWalkEnemy.SetActive(false);
                    animationStunEnemy.SetActive(true);
                    enemy.GetComponent<EnemyAIGame>().agentSpedZero();
                #endregion
                    light.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                light.SetActive(false);
                yield return new WaitForSeconds(1.8f);
                    enemy.GetComponent<EnemyAIGame>().agentSpedDefault();
                    animationWalkEnemy.SetActive(true);
                    animationStunEnemy.SetActive(false);
                    enemy.GetComponent<EnemyAIGame>().takePicture = false;
                yield return new WaitForSeconds(7);
                goPicture = true;
            }
        }
    #endregion
}
