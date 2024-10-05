using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    #region DATA
        #region INT
            public int currentIdol;
        #endregion  

        #region  UI
            public Text textNumberIdol;
        #endregion
    #endregion



    private void OnTriggerEnter(Collider obj)
    {
        if(obj.gameObject.tag == "IDOL")
        {
            currentIdol++;
            textNumberIdol.text = "Собрано " + currentIdol + "/7";
            Destroy(obj.gameObject);
        }
    }

    #region КОМПАС
        #region DATA
            #region GAME OBJECTS
                public GameObject[] allIdol;

                public GameObject currentIdolObj;
            #endregion

            #region TRANSFORM
                public Transform arrowObj;
            #endregion

            #region LIST
                public List<float> allDistanceIdol = new List<float>();
                public List<GameObject> idolObject = new List<GameObject>();
            #endregion

            #region FLOAT
                public float distanceToIdol;

                public float minDistanceToIdol;
            #endregion

            #region INT
                public int numberIdol;

                public int indexMinDistance;
            #endregion

            #region BOOL
                public bool goCurrentDistanceToIdol;
            #endregion
        #endregion

        void Update()
        {
            if(!goCurrentDistanceToIdol)
                goMinDistanceKompace();
        }


        void goMinDistanceKompace()
        {
            if(allIdol[0] == null && allIdol[1] == null && allIdol[2] == null && allIdol[3] == null && allIdol[4] == null && allIdol[5] == null && allIdol[6] == null)
                return;
            goCurrentDistanceToIdol = true;
            if(allIdol[numberIdol] != null)
            {distanceToIdol = Vector3.Distance(transform.position, allIdol[numberIdol].transform.position);
            allDistanceIdol.Add(distanceToIdol);
            idolObject.Add(allIdol[numberIdol]);
            }
            numberIdol++;
            
            if(allIdol[numberIdol] != null)
            {distanceToIdol = Vector3.Distance(transform.position, allIdol[numberIdol].transform.position);
            allDistanceIdol.Add(distanceToIdol);
            idolObject.Add(allIdol[numberIdol]);
            }
            numberIdol++;

            if(allIdol[numberIdol] != null)
            {distanceToIdol = Vector3.Distance(transform.position, allIdol[numberIdol].transform.position);
            allDistanceIdol.Add(distanceToIdol);
            idolObject.Add(allIdol[numberIdol]);
            }
            numberIdol++;

            if(allIdol[numberIdol] != null)
            {distanceToIdol = Vector3.Distance(transform.position, allIdol[numberIdol].transform.position);
            allDistanceIdol.Add(distanceToIdol);
            idolObject.Add(allIdol[numberIdol]);
            }
            numberIdol++;

            if(allIdol[numberIdol] != null)
            {distanceToIdol = Vector3.Distance(transform.position, allIdol[numberIdol].transform.position);
            allDistanceIdol.Add(distanceToIdol);
            idolObject.Add(allIdol[numberIdol]);
            }
            numberIdol++;

            if(allIdol[numberIdol] != null)
            {distanceToIdol = Vector3.Distance(transform.position, allIdol[numberIdol].transform.position);
            allDistanceIdol.Add(distanceToIdol);
            idolObject.Add(allIdol[numberIdol]);
            }
            numberIdol++;

            if(allIdol[numberIdol] != null)
            {distanceToIdol = Vector3.Distance(transform.position, allIdol[numberIdol].transform.position);
            allDistanceIdol.Add(distanceToIdol);
            idolObject.Add(allIdol[numberIdol]);
            }
            numberIdol=0;

            minDistanceToIdol = allDistanceIdol.Min();
            indexMinDistance = allDistanceIdol.IndexOf(minDistanceToIdol);
            currentIdolObj = idolObject[indexMinDistance];

            Vector3 direction = currentIdolObj.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            arrowObj.transform.rotation = Quaternion.Euler(0, rotation.eulerAngles.y, 0);

            allDistanceIdol.Clear();
            idolObject.Clear();

            goCurrentDistanceToIdol = false;
        }   
    #endregion
}
