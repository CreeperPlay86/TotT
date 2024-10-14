using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoApparat : MonoBehaviour
{
    #region DATA
        #region GAME OBJECTS and TRANSFORN||VECTOR
            public GameObject light;

            public GameObject enemy;
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
            }
        }
    }



    #region VOID and IEnumerator
        IEnumerator doPicture()
        {
            light.SetActive(true);
            yield return new WaitForSeconds(0.7f);
            light.SetActive(false);
                #region ОПРЕДЕЛЕНИЕ ДИСТАНЦИИ ДО ENEMY
                    distanceToEnemy = Vector3.Distance(enemy.transform.position, transform.position);

                    if(distanceToEnemy <= 15f)
                    {
                        enemy.GetComponent<MeshRenderer>().enabled = true;

                        yield return new WaitForSeconds(3f);
                        enemy.GetComponent<MeshRenderer>().enabled = false;
                    }
                #endregion
            yield return new WaitForSeconds(7.3f);
            goPicture = true;
        }
    #endregion
}
