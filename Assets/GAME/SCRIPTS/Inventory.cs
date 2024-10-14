using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour // ОТКРЫТИЕ - ИМЕЕТСЯ ЛИ ОБЬЕКТ В 1 ЯЧЕЙКЕ - ЗАГРУЗКА ЭТОГО ОБЬЕКТА В 1 ЯЧЕЙКА
                                       // ПОДБОР - ОПРЕДЕЛЕНИЕ ЯЧЕЙКИ ДЛЯ ПРЕДМЕТА - ЗАКРЫТИЕ ЯЧЕЙКИ
{
    #region DATA
        #region GAME OBJECTS
            public GameObject inventoryPanel;

            public GameObject[] objInInventory; 

            public GameObject[] indexInventory1;
            public GameObject[] indexInventory2;
            public GameObject[] indexInventory3;
            public GameObject[] indexInventory4;
        #endregion  

        #region BOOL
            #region имеется ли этот обьект
                public bool isHaveObj1;
                public bool isHaveObj2;
                public bool isHaveObj3;
                public bool isHaveObj4;
            #endregion

            #region ЗАНЯТ ЛИ ИНДЕКС ИНВЕНТАРЯ
                public bool isLockIndex1;
                public bool isLockIndex2;
                public bool isLockIndex3;
                public bool isLockIndex4;
            #endregion
        #endregion

        #region INT
            public int indexObj1; // НЕ ДОЛЖНО РАВНЯТЬ НУЛЮ !!!!!!!
            public int indexObj2;
            public int indexObj3;
            public int indexObj4;
        #endregion
    #endregion



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            plusObj();
        }
    }



    #region VOID and IENUMERATOR
        public void plusObj()
        {
            #region ПОДБОР 1 ОБЬЕКТА
                if(!isHaveObj1)
                {
                    if(!isLockIndex1)
                    {
                        isHaveObj1 = true;
                        indexObj1 = 1;
                        isLockIndex1 = true;
                        indexInventory1[0].SetActive(true);
                        indexInventory1[1].SetActive(false);
                        indexInventory1[2].SetActive(false);
                        indexInventory1[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex2)
                    {
                        isHaveObj1 = true;
                        indexObj1 = 2;
                        isLockIndex2 = true;
                        indexInventory1[0].SetActive(false);
                        indexInventory1[1].SetActive(true);
                        indexInventory1[2].SetActive(false);
                        indexInventory1[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex3)
                    {
                        isHaveObj1 = true;
                        indexObj1 = 3;
                        isLockIndex3 = true;
                        indexInventory1[0].SetActive(false);
                        indexInventory1[1].SetActive(false);
                        indexInventory1[2].SetActive(true);
                        indexInventory1[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex4)
                    {
                        isHaveObj1 = true;
                        indexObj1 = 4;
                        isLockIndex4 = true;
                        indexInventory1[0].SetActive(false);
                        indexInventory1[1].SetActive(false);
                        indexInventory1[2].SetActive(false);
                        indexInventory1[3].SetActive(true);
                        return;
                    }
                }
            #endregion

            #region ПОДБОР 2 ОБЬЕКТА
                if(!isHaveObj2)
                {
                    if(!isLockIndex1)
                    {
                        isHaveObj2 = true;
                        indexObj2 = 1;
                        isLockIndex1 = true;
                        indexInventory2[0].SetActive(true);
                        indexInventory2[1].SetActive(false);
                        indexInventory2[2].SetActive(false);
                        indexInventory2[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex2)
                    {
                        isHaveObj2 = true;
                        indexObj2 = 2;
                        isLockIndex2 = true;
                        indexInventory2[0].SetActive(false);
                        indexInventory2[1].SetActive(true);
                        indexInventory2[2].SetActive(false);
                        indexInventory2[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex3)
                    {
                        isHaveObj2 = true;
                        indexObj2 = 3;
                        isLockIndex3 = true;
                        indexInventory3[0].SetActive(false);
                        indexInventory3[1].SetActive(false);
                        indexInventory3[2].SetActive(true);
                        indexInventory3[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex4)
                    {
                        isHaveObj2 = true;
                        indexObj2 = 4;
                        isLockIndex4 = true;
                        indexInventory4[0].SetActive(false);
                        indexInventory4[1].SetActive(false);
                        indexInventory4[2].SetActive(false);
                        indexInventory4[3].SetActive(true);
                        return;
                    }
                }
            #endregion

            #region ПОДБОР 3 ОБЬЕКТА
                if(!isHaveObj3)
                {
                    if(!isLockIndex1)
                    {
                        isHaveObj3 = true;
                        indexObj3 = 1;
                        isLockIndex1 = true;
                        indexInventory3[0].SetActive(true);
                        indexInventory3[1].SetActive(false);
                        indexInventory3[2].SetActive(false);
                        indexInventory3[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex2)
                    {
                        isHaveObj3 = true;
                        indexObj3 = 2;
                        isLockIndex2 = true;
                        indexInventory3[0].SetActive(false);
                        indexInventory3[1].SetActive(true);
                        indexInventory3[2].SetActive(false);
                        indexInventory3[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex3)
                    {
                        isHaveObj3 = true;
                        indexObj3 = 3;
                        isLockIndex3 = true;
                        indexInventory3[0].SetActive(false);
                        indexInventory3[1].SetActive(false);
                        indexInventory3[2].SetActive(true);
                        indexInventory3[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex4)
                    {
                        isHaveObj3 = true;
                        indexObj3 = 4;
                        isLockIndex4 = true;
                        indexInventory3[0].SetActive(false);
                        indexInventory3[1].SetActive(false);
                        indexInventory3[2].SetActive(false);
                        indexInventory3[3].SetActive(true);
                        return;
                    }
                }
            #endregion

            #region ПОДБОР 4 ОБЬЕКТА
                if(!isHaveObj4)
                {
                    if(!isLockIndex1)
                    {
                        isHaveObj4 = true;
                        indexObj4 = 1;
                        isLockIndex1 = true;
                        indexInventory4[0].SetActive(true);
                        indexInventory4[1].SetActive(false);
                        indexInventory4[2].SetActive(false);
                        indexInventory4[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex2)
                    {
                        isHaveObj4 = true;
                        indexObj4 = 2;
                        isLockIndex2 = true;
                        indexInventory4[0].SetActive(false);
                        indexInventory4[1].SetActive(true);
                        indexInventory4[2].SetActive(false);
                        indexInventory4[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex3)
                    {
                        isHaveObj4 = true;
                        indexObj4 = 3;
                        isLockIndex3 = true;
                        indexInventory4[0].SetActive(false);
                        indexInventory4[1].SetActive(false);
                        indexInventory4[2].SetActive(true);
                        indexInventory4[3].SetActive(false);
                        return;
                    }
                    if(!isLockIndex4)
                    {
                        isHaveObj4 = true;
                        indexObj4 = 4;
                        isLockIndex4 = true;
                        indexInventory4[0].SetActive(false);
                        indexInventory4[1].SetActive(false);
                        indexInventory4[2].SetActive(false);
                        indexInventory4[3].SetActive(true);
                        return;
                    }
                }
            #endregion
        }
    #endregion
}