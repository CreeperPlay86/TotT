using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMain : MonoBehaviour
{
    #region DATA
        #region SPRITE
            public SpriteRenderer[] SP;
        #endregion

        #region BOOL
            public bool isLockIndex1;
            public bool isLockIndex2;
            public bool isLockIndex3;
            public bool isLockIndex4;
            public bool isLockIndex5;
            public bool isLockIndex6;
            public bool isLockIndex7;

            #region НАЛИЧИЕ ПРЕДМЕТА
                public bool isHaveCamera; // ФОТОАППАРАТ  
                public bool isHaveCandles; // СВЕЧКИ       
                public bool isHaveCircle; // ЧАСТИ САТАНИЧЕСКОГО КРУГА  
                public bool isHavePapa; // ЧЕРЕП ОТЦА ГГ
                public bool isHaveKey; // КЛЮЧ
                public bool isHaveAxe; // ТОПОР 
                public bool isHavePickaxe; // КИРКА
                //public bool isOpenInventory;
            #endregion
        #endregion

        #region STRING
            public string nameCamera;
            public string nameCandles;
            public string nameCircle;
            public string namePapa;
            public string nameKey;
            public string nameAxe;
            public string nameOPickaxe;
        #endregion

        #region INT
            public int indexCamera;
            public int indexCCandles;
            public int indexCircle;
            public int indexPapa;
            public int indexKey;
            public int indexAxe;
            public int indexPickaxe;
        #endregion

        #region UI
            public GameObject[] imgCamera;
            public GameObject[] imgCandles;
            public GameObject[] imgCircle;
            public GameObject[] imgPapa;
            public GameObject[] imgKey;
            public GameObject[] imgAxe;
            public GameObject[] imgOPickaxe;
        #endregion
    #endregion



    #region VOID
        #region ПОДБОР ПРЕДМЕТА - ФОТОАППАРАТ
            public void plusObjCamera()
            {
                if(!isLockIndex1)
                {
                    isLockIndex1 = true;
                    isHaveCamera = true;
                    indexCamera = 1;
                    imgCamera[0].SetActive(true);
                    imgCandles[0].SetActive(false);
                    imgCircle[0].SetActive(false);
                    imgPapa[0].SetActive(false);
                    imgKey[0].SetActive(false);
                    imgAxe[0].SetActive(false);
                    imgOPickaxe[0].SetActive(false);
                    return;
                }

                if(!isLockIndex2)
                {
                    isLockIndex2 = true;
                    isHaveCamera = true;
                    indexCamera = 2;
                      imgCamera[1].SetActive(true);
                     imgCandles[1].SetActive(false);
                      imgCircle[1].SetActive(false);
                        imgPapa[1].SetActive(false);
                         imgKey[1].SetActive(false);
                         imgAxe[1].SetActive(false);
                    imgOPickaxe[1].SetActive(false);
                    return;
                }

                if(!isLockIndex3)
                {
                    isLockIndex3 = true;
                    isHaveCamera = true;
                    indexCamera = 3;
                      imgCamera[2].SetActive(true);
                     imgCandles[2].SetActive(false);
                      imgCircle[2].SetActive(false);
                        imgPapa[2].SetActive(false);
                         imgKey[2].SetActive(false);
                         imgAxe[2].SetActive(false);
                    imgOPickaxe[2].SetActive(false);
                    return;
                }

                if(!isLockIndex4)
                {
                    isLockIndex4 = true;
                    isHaveCamera = true;
                    indexCamera = 4;
                      imgCamera[3].SetActive(true);
                     imgCandles[3].SetActive(false);
                      imgCircle[3].SetActive(false);
                        imgPapa[3].SetActive(false);
                         imgKey[3].SetActive(false);
                         imgAxe[3].SetActive(false);
                    imgOPickaxe[3].SetActive(false);
                    return;
                }

                if(!isLockIndex5)
                {
                    isLockIndex5 = true;
                    isHaveCamera = true;
                    indexCamera = 5;
                      imgCamera[4].SetActive(true);
                     imgCandles[4].SetActive(false);
                      imgCircle[4].SetActive(false);
                        imgPapa[4].SetActive(false);
                         imgKey[4].SetActive(false);
                         imgAxe[4].SetActive(false);
                    imgOPickaxe[4].SetActive(false);
                    return;
                }

                if(!isLockIndex6)
                {
                    isLockIndex6 = true;
                    isHaveCamera = true;
                    indexCamera = 6;
                      imgCamera[5].SetActive(true);
                     imgCandles[5].SetActive(false);
                      imgCircle[5].SetActive(false);
                        imgPapa[5].SetActive(false);
                         imgKey[5].SetActive(false);
                         imgAxe[5].SetActive(false);
                    imgOPickaxe[5].SetActive(false);
                    return;
                }

                if(!isLockIndex7)
                {
                    isLockIndex7 = true;
                    isHaveCamera = true;
                    indexCamera = 7;
                      imgCamera[6].SetActive(true);
                     imgCandles[6].SetActive(false);
                      imgCircle[6].SetActive(false);
                        imgPapa[6].SetActive(false);
                         imgKey[6].SetActive(false);
                         imgAxe[6].SetActive(false);
                    imgOPickaxe[6].SetActive(false);
                    return;
                }
            }
        #endregion

        #region ПОДБОР ПРЕДМЕТА - СВЕЧКИ
            public void plusObjCandles()
            {
                if(!isLockIndex1)
                {
                    isLockIndex1 = true;
                    isHaveCandles = true;
                    indexCCandles = 1;
                      imgCamera[0].SetActive(false);
                     imgCandles[0].SetActive(true);
                      imgCircle[0].SetActive(false);
                        imgPapa[0].SetActive(false);
                         imgKey[0].SetActive(false);
                         imgAxe[0].SetActive(false);
                    imgOPickaxe[0].SetActive(false);
                    return;
                }

                if(!isLockIndex2)
                {
                    isLockIndex2 = true;
                    isHaveCandles = true;
                    indexCCandles = 2;
                      imgCamera[1].SetActive(false);
                     imgCandles[1].SetActive(true);
                      imgCircle[1].SetActive(false);
                        imgPapa[1].SetActive(false);
                         imgKey[1].SetActive(false);
                         imgAxe[1].SetActive(false);
                    imgOPickaxe[1].SetActive(false);
                    return;
                }

                if(!isLockIndex3)
                {
                    isLockIndex3 = true;
                    isHaveCandles = true;
                    indexCCandles = 3;
                      imgCamera[2].SetActive(false);
                     imgCandles[2].SetActive(true);
                      imgCircle[2].SetActive(false);
                        imgPapa[2].SetActive(false);
                         imgKey[2].SetActive(false);
                         imgAxe[2].SetActive(false);
                    imgOPickaxe[2].SetActive(false);
                    return;
                }

                if(!isLockIndex4)
                {
                    isLockIndex4 = true;
                    isHaveCandles = true;
                    indexCCandles = 4;
                      imgCamera[3].SetActive(false);
                     imgCandles[3].SetActive(true);
                      imgCircle[3].SetActive(false);
                        imgPapa[3].SetActive(false);
                         imgKey[3].SetActive(false);
                         imgAxe[3].SetActive(false);
                    imgOPickaxe[3].SetActive(false);
                    return;
                }

                if(!isLockIndex5)
                {
                    isLockIndex5 = true;
                    isHaveCandles = true;
                    indexCCandles = 5;
                      imgCamera[4].SetActive(false);
                     imgCandles[4].SetActive(true);
                      imgCircle[4].SetActive(false);
                        imgPapa[4].SetActive(false);
                         imgKey[4].SetActive(false);
                         imgAxe[4].SetActive(false);
                    imgOPickaxe[4].SetActive(false);
                    return;
                }

                if(!isLockIndex6)
                {
                    isLockIndex6 = true;
                    isHaveCandles = true;
                    indexCCandles = 6;
                      imgCamera[5].SetActive(false);
                     imgCandles[5].SetActive(true);
                      imgCircle[5].SetActive(false);
                        imgPapa[5].SetActive(false);
                         imgKey[5].SetActive(false);
                         imgAxe[5].SetActive(false);
                    imgOPickaxe[5].SetActive(false);
                    return;
                }

                if(!isLockIndex7)
                {
                    isLockIndex7 = true;
                    isHaveCandles = true;
                    indexCCandles = 7;
                      imgCamera[6].SetActive(false);
                     imgCandles[6].SetActive(true);
                      imgCircle[6].SetActive(false);
                        imgPapa[6].SetActive(false);
                         imgKey[6].SetActive(false);
                         imgAxe[6].SetActive(false);
                    imgOPickaxe[6].SetActive(false);
                    return;
                }
            }
        #endregion

        #region ПОДБОР ПРЕДМЕТА - ЧАСТЬ КРУГА
            public void plusObjCircle()
            {
                if(!isLockIndex1)
                {
                    isLockIndex1 = true;
                    isHaveCircle = true;
                    indexCircle = 1;
                      imgCamera[0].SetActive(false);
                     imgCandles[0].SetActive(false);
                      imgCircle[0].SetActive(true);
                        imgPapa[0].SetActive(false);
                         imgKey[0].SetActive(false);
                         imgAxe[0].SetActive(false);
                    imgOPickaxe[0].SetActive(false);
                    return;
                }

                if(!isLockIndex2)
                {
                    isLockIndex2 = true;
                    isHaveCircle = true;
                    indexCircle = 2;
                      imgCamera[1].SetActive(false);
                     imgCandles[1].SetActive(false);
                      imgCircle[1].SetActive(true);
                        imgPapa[1].SetActive(false);
                         imgKey[1].SetActive(false);
                         imgAxe[1].SetActive(false);
                    imgOPickaxe[1].SetActive(false);
                    return;
                }

                if(!isLockIndex3)
                {
                    isLockIndex3 = true;
                    isHaveCircle = true;
                    indexCircle = 3;
                      imgCamera[2].SetActive(false);
                     imgCandles[2].SetActive(false);
                      imgCircle[2].SetActive(true);
                        imgPapa[2].SetActive(false);
                         imgKey[2].SetActive(false);
                         imgAxe[2].SetActive(false);
                    imgOPickaxe[2].SetActive(false);
                    return;
                }

                if(!isLockIndex4)
                {
                    isLockIndex4 = true;
                    isHaveCircle = true;
                    indexCircle = 4;
                      imgCamera[3].SetActive(false);
                     imgCandles[3].SetActive(false);
                      imgCircle[3].SetActive(true);
                        imgPapa[3].SetActive(false);
                         imgKey[3].SetActive(false);
                         imgAxe[3].SetActive(false);
                    imgOPickaxe[3].SetActive(false);
                    return;
                }

                if(!isLockIndex5)
                {
                    isLockIndex5 = true;
                    isHaveCircle = true;
                    indexCircle = 5;
                      imgCamera[4].SetActive(false);
                     imgCandles[4].SetActive(false);
                      imgCircle[4].SetActive(true);
                        imgPapa[4].SetActive(false);
                         imgKey[4].SetActive(false);
                         imgAxe[4].SetActive(false);
                    imgOPickaxe[4].SetActive(false);
                    return;
                }

                if(!isLockIndex6)
                {
                    isLockIndex6 = true;
                    isHaveCircle = true;
                    indexCircle = 6;
                      imgCamera[5].SetActive(false);
                     imgCandles[5].SetActive(false);
                      imgCircle[5].SetActive(true);
                        imgPapa[5].SetActive(false);
                         imgKey[5].SetActive(false);
                         imgAxe[5].SetActive(false);
                    imgOPickaxe[5].SetActive(false);
                    return;
                }

                if(!isLockIndex7)
                {
                    isLockIndex7 = true;
                    isHaveCircle = true;
                    indexCircle = 7;
                      imgCamera[6].SetActive(false);
                     imgCandles[6].SetActive(false);
                      imgCircle[6].SetActive(true);
                        imgPapa[6].SetActive(false);
                         imgKey[6].SetActive(false);
                         imgAxe[6].SetActive(false);
                    imgOPickaxe[6].SetActive(false);
                    return;
                }
            }
        #endregion

        #region ПОДБОР ПРЕДМЕТА - ЧЕРЕП ОТЦА
            public void plusObjPapa()
            {
                if(!isLockIndex1)
                {
                    isLockIndex1 = true;
                    isHavePapa = true;
                    indexPapa = 1;
                      imgCamera[0].SetActive(false);
                     imgCandles[0].SetActive(false);
                      imgCircle[0].SetActive(false);
                        imgPapa[0].SetActive(true);
                         imgKey[0].SetActive(false);
                         imgAxe[0].SetActive(false);
                    imgOPickaxe[0].SetActive(false);
                    return;
                }

                if(!isLockIndex2)
                {
                    isLockIndex2 = true;
                    isHavePapa = true;
                    indexPapa = 2;
                      imgCamera[1].SetActive(false);
                     imgCandles[1].SetActive(false);
                      imgCircle[1].SetActive(false);
                        imgPapa[1].SetActive(true);
                         imgKey[1].SetActive(false);
                         imgAxe[1].SetActive(false);
                    imgOPickaxe[1].SetActive(false);
                    return;
                }

                if(!isLockIndex3)
                {
                    isLockIndex3 = true;
                    isHavePapa = true;
                    indexPapa = 3;
                      imgCamera[2].SetActive(false);
                     imgCandles[2].SetActive(false);
                      imgCircle[2].SetActive(false);
                        imgPapa[2].SetActive(true);
                         imgKey[2].SetActive(false);
                         imgAxe[2].SetActive(false);
                    imgOPickaxe[2].SetActive(false);
                    return;
                }

                if(!isLockIndex4)
                {
                    isLockIndex4 = true;
                    isHavePapa = true;
                    indexPapa = 4;
                      imgCamera[3].SetActive(false);
                     imgCandles[3].SetActive(false);
                      imgCircle[3].SetActive(false);
                        imgPapa[3].SetActive(true);
                         imgKey[3].SetActive(false);
                         imgAxe[3].SetActive(false);
                    imgOPickaxe[3].SetActive(false);
                    return;
                }

                if(!isLockIndex5)
                {
                    isLockIndex5 = true;
                    isHavePapa = true;
                    indexPapa = 5;
                      imgCamera[4].SetActive(false);
                     imgCandles[4].SetActive(false);
                      imgCircle[4].SetActive(false);
                        imgPapa[4].SetActive(true);
                         imgKey[4].SetActive(false);
                         imgAxe[4].SetActive(false);
                    imgOPickaxe[4].SetActive(false);
                    return;
                }

                if(!isLockIndex6)
                {
                    isLockIndex6 = true;
                    isHavePapa = true;
                    indexPapa = 6;
                      imgCamera[5].SetActive(false);
                     imgCandles[5].SetActive(false);
                      imgCircle[5].SetActive(false);
                        imgPapa[5].SetActive(true);
                         imgKey[5].SetActive(false);
                         imgAxe[5].SetActive(false);
                    imgOPickaxe[5].SetActive(false);
                    return;
                }

                if(!isLockIndex7)
                {
                    isLockIndex7 = true;
                    isHavePapa = true;
                    indexPapa = 7;
                      imgCamera[6].SetActive(false);
                     imgCandles[6].SetActive(false);
                      imgCircle[6].SetActive(false);
                        imgPapa[6].SetActive(true);
                         imgKey[6].SetActive(false);
                         imgAxe[6].SetActive(false);
                    imgOPickaxe[6].SetActive(false);
                    return;
                }
            }
        #endregion

        #region ПОДБОР ПРЕДМЕТА - КЛЮЧА
            public void plusObjKey()
            {
                if(!isLockIndex1)
                {
                    isLockIndex1 = true;
                    isHaveKey = true;
                    indexKey = 1;
                      imgCamera[0].SetActive(false);
                     imgCandles[0].SetActive(false);
                      imgCircle[0].SetActive(false);
                        imgPapa[0].SetActive(false);
                         imgKey[0].SetActive(true);
                         imgAxe[0].SetActive(false);
                    imgOPickaxe[0].SetActive(false);
                    return;
                }

                if(!isLockIndex2)
                {
                    isLockIndex2 = true;
                    isHaveKey = true;
                    indexKey = 2;
                      imgCamera[1].SetActive(false);
                     imgCandles[1].SetActive(false);
                      imgCircle[1].SetActive(false);
                        imgPapa[1].SetActive(false);
                         imgKey[1].SetActive(true);
                         imgAxe[1].SetActive(false);
                    imgOPickaxe[1].SetActive(false);
                    return;
                }

                if(!isLockIndex3)
                {
                    isLockIndex3 = true;
                    isHaveKey = true;
                    indexKey = 3;
                      imgCamera[2].SetActive(false);
                     imgCandles[2].SetActive(false);
                      imgCircle[2].SetActive(false);
                        imgPapa[2].SetActive(false);
                         imgKey[2].SetActive(true);
                         imgAxe[2].SetActive(false);
                    imgOPickaxe[2].SetActive(false);
                    return;
                }

                if(!isLockIndex4)
                {
                    isLockIndex4 = true;
                    isHaveKey = true;
                    indexKey = 4;
                      imgCamera[3].SetActive(false);
                     imgCandles[3].SetActive(false);
                      imgCircle[3].SetActive(false);
                        imgPapa[3].SetActive(false);
                         imgKey[3].SetActive(true);
                         imgAxe[3].SetActive(false);
                    imgOPickaxe[3].SetActive(false);
                    return;
                }

                if(!isLockIndex5)
                {
                    isLockIndex5 = true;
                    isHaveKey = true;
                    indexKey = 5;
                      imgCamera[4].SetActive(false);
                     imgCandles[4].SetActive(false);
                      imgCircle[4].SetActive(false);
                        imgPapa[4].SetActive(false);
                         imgKey[4].SetActive(true);
                         imgAxe[4].SetActive(false);
                    imgOPickaxe[4].SetActive(false);
                    return;
                }

                if(!isLockIndex6)
                {
                    isLockIndex6 = true;
                    isHaveKey = true;
                    indexKey = 6;
                      imgCamera[5].SetActive(false);
                     imgCandles[5].SetActive(false);
                      imgCircle[5].SetActive(false);
                        imgPapa[5].SetActive(false);
                         imgKey[5].SetActive(true);
                         imgAxe[5].SetActive(false);
                    imgOPickaxe[5].SetActive(false);
                    return;
                }

                if(!isLockIndex7)
                {
                    isLockIndex7 = true;
                    isHaveKey = true;
                    indexKey = 7;
                      imgCamera[6].SetActive(false);
                     imgCandles[6].SetActive(false);
                      imgCircle[6].SetActive(false);
                        imgPapa[6].SetActive(false);
                         imgKey[6].SetActive(true);
                         imgAxe[6].SetActive(false);
                    imgOPickaxe[6].SetActive(false);
                    return;
                }
            }
        #endregion

        #region ПОДБОР ПРЕДМЕТА - ТОПОРА
            public void plusObjAxe()
            {
                if(!isLockIndex1)
                {
                    isLockIndex1 = true;
                    isHaveAxe = true;
                    indexAxe = 1;
                      imgCamera[0].SetActive(false);
                     imgCandles[0].SetActive(false);
                      imgCircle[0].SetActive(false);
                        imgPapa[0].SetActive(false);
                         imgKey[0].SetActive(false);
                         imgAxe[0].SetActive(true);
                    imgOPickaxe[0].SetActive(false);
                    return;
                }

                if(!isLockIndex2)
                {
                    isLockIndex2 = true;
                    isHaveAxe = true;
                    indexAxe = 2;
                      imgCamera[1].SetActive(false);
                     imgCandles[1].SetActive(false);
                      imgCircle[1].SetActive(false);
                        imgPapa[1].SetActive(false);
                         imgKey[1].SetActive(false);
                         imgAxe[1].SetActive(true);
                    imgOPickaxe[1].SetActive(false);
                    return;
                }

                if(!isLockIndex3)
                {
                    isLockIndex3 = true;
                    isHaveAxe = true;
                    indexAxe = 3;
                      imgCamera[2].SetActive(false);
                     imgCandles[2].SetActive(false);
                      imgCircle[2].SetActive(false);
                        imgPapa[2].SetActive(false);
                         imgKey[2].SetActive(false);
                         imgAxe[2].SetActive(true);
                    imgOPickaxe[2].SetActive(false);
                    return;
                }

                if(!isLockIndex4)
                {
                    isLockIndex4 = true;
                    isHaveAxe = true;
                    indexAxe = 4;
                      imgCamera[3].SetActive(false);
                     imgCandles[3].SetActive(false);
                      imgCircle[3].SetActive(false);
                        imgPapa[3].SetActive(false);
                         imgKey[3].SetActive(false);
                         imgAxe[3].SetActive(true);
                    imgOPickaxe[3].SetActive(false);
                    return;
                }

                if(!isLockIndex5)
                {
                    isLockIndex5 = true;
                    isHaveAxe = true;
                    indexAxe = 5;
                      imgCamera[4].SetActive(false);
                     imgCandles[4].SetActive(false);
                      imgCircle[4].SetActive(false);
                        imgPapa[4].SetActive(false);
                         imgKey[4].SetActive(false);
                         imgAxe[4].SetActive(true);
                    imgOPickaxe[4].SetActive(false);
                    return;
                }

                if(!isLockIndex6)
                {
                    isLockIndex6 = true;
                    isHaveAxe = true;
                    indexAxe = 6;
                      imgCamera[5].SetActive(false);
                     imgCandles[5].SetActive(false);
                      imgCircle[5].SetActive(false);
                        imgPapa[5].SetActive(false);
                         imgKey[5].SetActive(false);
                         imgAxe[5].SetActive(true);
                    imgOPickaxe[5].SetActive(false);
                    return;
                }

                if(!isLockIndex7)
                {
                    isLockIndex7 = true;
                    isHaveAxe = true;
                    indexAxe = 7;
                      imgCamera[6].SetActive(false);
                     imgCandles[6].SetActive(false);
                      imgCircle[6].SetActive(false);
                        imgPapa[6].SetActive(false);
                         imgKey[6].SetActive(false);
                         imgAxe[6].SetActive(true);
                    imgOPickaxe[6].SetActive(false);
                    return;
                }
            }
        #endregion

        #region ПОДБОР ПРЕДМЕТА - КИРКИ
            public void Papa()
            {
                if(!isLockIndex1)
                {
                    isLockIndex1 = true;
                    isHavePickaxe = true;
                    indexPickaxe = 1;
                      imgCamera[0].SetActive(false);
                     imgCandles[0].SetActive(false);
                      imgCircle[0].SetActive(false);
                        imgPapa[0].SetActive(false);
                         imgKey[0].SetActive(false);
                         imgAxe[0].SetActive(false);
                    imgOPickaxe[0].SetActive(true);
                    return;
                }

                if(!isLockIndex2)
                {
                    isLockIndex2 = true;
                    isHavePickaxe = true;
                    indexPickaxe = 2;
                      imgCamera[1].SetActive(false);
                     imgCandles[1].SetActive(false);
                      imgCircle[1].SetActive(false);
                        imgPapa[1].SetActive(false);
                         imgKey[1].SetActive(false);
                         imgAxe[1].SetActive(false);
                    imgOPickaxe[1].SetActive(true);
                    return;
                }

                if(!isLockIndex3)
                {
                    isLockIndex3 = true;
                    isHavePickaxe = true;
                    indexPickaxe = 3;
                      imgCamera[2].SetActive(false);
                     imgCandles[2].SetActive(false);
                      imgCircle[2].SetActive(false);
                        imgPapa[2].SetActive(false);
                         imgKey[2].SetActive(false);
                         imgAxe[2].SetActive(false);
                    imgOPickaxe[2].SetActive(true);
                    return;
                }

                if(!isLockIndex4)
                {
                    isLockIndex4 = true;
                    isHavePickaxe = true;
                    indexPickaxe = 4;
                      imgCamera[3].SetActive(false);
                     imgCandles[3].SetActive(false);
                      imgCircle[3].SetActive(false);
                        imgPapa[3].SetActive(false);
                         imgKey[3].SetActive(false);
                         imgAxe[3].SetActive(false);
                    imgOPickaxe[3].SetActive(true);
                    return;
                }

                if(!isLockIndex5)
                {
                    isLockIndex5 = true;
                    isHavePickaxe = true;
                    indexPickaxe = 5;
                      imgCamera[4].SetActive(false);
                     imgCandles[4].SetActive(false);
                      imgCircle[4].SetActive(false);
                        imgPapa[4].SetActive(false);
                         imgKey[4].SetActive(false);
                         imgAxe[4].SetActive(false);
                    imgOPickaxe[4].SetActive(true);
                    return;
                }

                if(!isLockIndex6)
                {
                    isLockIndex6 = true;
                    isHavePickaxe = true;
                    indexPickaxe = 6;
                      imgCamera[5].SetActive(false);
                     imgCandles[5].SetActive(false);
                      imgCircle[5].SetActive(false);
                        imgPapa[5].SetActive(false);
                         imgKey[5].SetActive(false);
                         imgAxe[5].SetActive(false);
                    imgOPickaxe[5].SetActive(true);
                    return;
                }

                if(!isLockIndex7)
                {
                    isLockIndex7 = true;
                    isHavePickaxe = true;
                    indexPickaxe = 7;
                      imgCamera[6].SetActive(false);
                     imgCandles[6].SetActive(false);
                      imgCircle[6].SetActive(false);
                        imgPapa[6].SetActive(false);
                         imgKey[6].SetActive(false);
                         imgAxe[6].SetActive(false);
                    imgOPickaxe[6].SetActive(true);
                    return;
                }
            }
        #endregion
    #endregion
}
