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
            public GameObject[] indexInventory5;
        #endregion  

        #region BOOL
            #region имеется ли этот обьект
                public bool isHaveObj1; // ФОТОАППАРАТ
                public bool isHaveObj2; // СВЕЧКИ
                public bool isHaveObj3; // ЧАСТИ САТАНИЧЕСКОГО КРУГА
                public bool isHaveObj4; // ЧЕРЕП ОТЦА ГГ
                public bool isHaveObj5; // КЛЮЧ

                public bool isOpenInventory;
            #endregion

            #region ЗАНЯТ ЛИ ИНДЕКС ИНВЕНТАРЯ
                public bool isLockIndex1;
                public bool isLockIndex2;
                public bool isLockIndex3;
                public bool isLockIndex4;
                public bool isLockIndex5;
            #endregion
        #endregion

        #region INT
            public int indexObj1; // НЕ ДОЛЖНО РАВНЯТЬ НУЛЮ !!!!!!!
            public int indexObj2;
            public int indexObj3;
            public int indexObj4;
            public int indexObj5;
        #endregion
    #endregion



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            openOrCloseInventory();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(isHaveObj1)
            {
                objInInventory[0].SetActive(true);
                objInInventory[1].SetActive(false);
                objInInventory[2].SetActive(false);
                objInInventory[3].SetActive(false);
                objInInventory[4].SetActive(false);
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            if(isHaveObj2)
            {
                objInInventory[0].SetActive(false);
                objInInventory[1].SetActive(true);
                objInInventory[2].SetActive(false);
                objInInventory[3].SetActive(false);
                objInInventory[4].SetActive(false);
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            if(isHaveObj3)
            {
                objInInventory[0].SetActive(false);
                objInInventory[1].SetActive(false);
                objInInventory[2].SetActive(true);
                objInInventory[3].SetActive(false);
                objInInventory[4].SetActive(false);
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            if(isHaveObj4)
            {
                objInInventory[0].SetActive(false);
                objInInventory[1].SetActive(false);
                objInInventory[2].SetActive(false);
                objInInventory[3].SetActive(true);
                objInInventory[4].SetActive(false);
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            if(isHaveObj5)
            {
                objInInventory[0].SetActive(false);
                objInInventory[1].SetActive(false);
                objInInventory[2].SetActive(false);
                objInInventory[3].SetActive(false);
                objInInventory[4].SetActive(true);
            }
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
                        indexInventory1[4].SetActive(false);
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
                        indexInventory1[4].SetActive(false);
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
                        indexInventory1[4].SetActive(false);
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
                        indexInventory1[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex5)
                    {
                        isHaveObj1 = true;
                        indexObj1 = 5;
                        isLockIndex5 = true;
                        indexInventory1[0].SetActive(false);
                        indexInventory1[1].SetActive(false);
                        indexInventory1[2].SetActive(false);
                        indexInventory1[3].SetActive(false);
                        indexInventory1[4].SetActive(true);
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
                        indexInventory1[4].SetActive(false);
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
                        indexInventory1[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex3)
                    {
                        isHaveObj2 = true;
                        indexObj2 = 3;
                        isLockIndex3 = true;
                        indexInventory2[0].SetActive(false);
                        indexInventory2[1].SetActive(false);
                        indexInventory2[2].SetActive(true);
                        indexInventory2[3].SetActive(false);
                        indexInventory2[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex4)
                    {
                        isHaveObj2 = true;
                        indexObj2 = 4;
                        isLockIndex4 = true;
                        indexInventory2[0].SetActive(false);
                        indexInventory2[1].SetActive(false);
                        indexInventory2[2].SetActive(false);
                        indexInventory2[3].SetActive(true);
                        indexInventory2[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex5)
                    {
                        isHaveObj2 = true;
                        indexObj2 = 5;
                        isLockIndex5 = true;
                        indexInventory2[0].SetActive(false);
                        indexInventory2[1].SetActive(false);
                        indexInventory2[2].SetActive(false);
                        indexInventory2[3].SetActive(false);
                        indexInventory2[4].SetActive(true);
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
                        indexInventory3[4].SetActive(false);
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
                        indexInventory3[4].SetActive(false);
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
                        indexInventory3[4].SetActive(false);
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
                        indexInventory3[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex5)
                    {
                        isHaveObj3 = true;
                        indexObj3 = 5;
                        isLockIndex5 = true;
                        indexInventory3[0].SetActive(false);
                        indexInventory3[1].SetActive(false);
                        indexInventory3[2].SetActive(false);
                        indexInventory3[3].SetActive(false);
                        indexInventory3[4].SetActive(true);
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
                        indexInventory4[4].SetActive(false);
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
                        indexInventory4[4].SetActive(false);
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
                        indexInventory4[4].SetActive(false);
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
                        indexInventory4[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex5)
                    {
                        isHaveObj4 = true;
                        indexObj4 = 5;
                        isLockIndex5 = true;
                        indexInventory4[0].SetActive(false);
                        indexInventory4[1].SetActive(false);
                        indexInventory4[2].SetActive(false);
                        indexInventory4[3].SetActive(false);
                        indexInventory4[4].SetActive(true);
                        return;
                    }
                }
            #endregion

            #region ПОДБОР 5 ОБЬЕКТА
                if(!isHaveObj5)
                {
                    if(!isLockIndex1)
                    {
                        isHaveObj5 = true;
                        indexObj5 = 1;
                        isLockIndex1 = true;
                        indexInventory5[0].SetActive(true);
                        indexInventory5[1].SetActive(false);
                        indexInventory5[2].SetActive(false);
                        indexInventory5[3].SetActive(false);
                        indexInventory5[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex2)
                    {
                        isHaveObj5 = true;
                        indexObj5 = 2;
                        isLockIndex2 = true;
                        indexInventory5[0].SetActive(false);
                        indexInventory5[1].SetActive(true);
                        indexInventory5[2].SetActive(false);
                        indexInventory5[3].SetActive(false);
                        indexInventory5[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex3)
                    {
                        isHaveObj5 = true;
                        indexObj5 = 3;
                        isLockIndex3 = true;
                        indexInventory5[0].SetActive(false);
                        indexInventory5[1].SetActive(false);
                        indexInventory5[2].SetActive(true);
                        indexInventory5[3].SetActive(false);
                        indexInventory5[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex4)
                    {
                        isHaveObj5 = true;
                        indexObj5 = 4;
                        isLockIndex4 = true;
                        indexInventory5[0].SetActive(false);
                        indexInventory5[1].SetActive(false);
                        indexInventory5[2].SetActive(false);
                        indexInventory5[3].SetActive(true);
                        indexInventory5[4].SetActive(false);
                        return;
                    }
                    if(!isLockIndex5)
                    {
                        isHaveObj5 = true;
                        indexObj5 = 5;
                        isLockIndex5 = true;
                        indexInventory5[0].SetActive(false);
                        indexInventory5[1].SetActive(false);
                        indexInventory5[2].SetActive(false);
                        indexInventory5[3].SetActive(false);
                        indexInventory5[4].SetActive(true);
                        return;
                    }
                }
            #endregion
        }

        public void openOrCloseInventory()
        {
            if(!isOpenInventory)
            {
                inventoryPanel.SetActive(true);
            }
            else
            {
                inventoryPanel.SetActive(false);
            }
            isOpenInventory = !isOpenInventory;
        }
    #endregion
}