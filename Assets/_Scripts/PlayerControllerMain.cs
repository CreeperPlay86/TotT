using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControllerMain : MonoBehaviour
{
    #region DATA
        #region GAME OBJECTS and UI
            public Camera camera;

            public GameObject clickLkmUI;

            public GameObject enemy;

                #region START
                    public GameObject uiGoToOwner;

                    public GameObject metkaDoorOwner;
                #endregion

                #region SOUND
                    public GameObject soundActiveEnemy;

                    public GameObject soundStone;

                    public GameObject soundOpenDoorShelf;
                #endregion

            public GameObject animationHands;
        #endregion

        #region FLOAT
            public float distance;
        #endregion

        #region LAYER
            public LayerMask layer;
        #endregion

        #region INT
            public int level;

            public int health;
        #endregion

        #region BOOL
            public bool inTheWardrobe;

            public bool haveAxe;
        #endregion

        #region CONNECT
            public InventoryMain inv;
        #endregion
    #endregion
    


    void Start()
    {
        health = 3;
        //level = PlayerPrefs.GetInt("level");
        #region растановка игрока и обьеков по уровню
        //    if(level == 0)
        //    {
        //        uiGoToOwner.SetActive(true);
        //        metkaDoorOwner.SetActive(true);
        //    }
        //    if(level == 1)
        //    {
        //        //transform.position = new Vctor3(); // игрок выходит из той комнаты  
        //    }
        //    if(level == 2)
        //    {
        //        //тоже самое что и level == 1                       // и видит как появляется дух и игрок бежит в любую комнату со шкафом
        //    }
        //    if(level == 3)
        //    {
        //        //transform.position = new Vector3();
        //        //игрок спрятался в шкафу И СЕЙЧАС ПОЙДЕТ НА ПОИСК КАРТИНЫ;
        //    }
        //    if(level == 4)
        //    {
        //        // transform.position = new Vector3(); // игрок уже нашел место с картиной и сейчас отправится на поиск подходящей комнаты для ритуала
        //    }
        //    if(level == 5)
        //    {
        //        // transform.position = new Vector3(); // игрок нашел комнату для ритуала и сейчас пойдет на поиски всех предметов и потом завершает игру.
        //    }
        #endregion
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3(0, 0, 0);
        }
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0 ));

        if (Physics.Raycast(ray, out hit, distance, layer))
        {
            
            if(hit.collider.tag == "fotoapparat")
            {
                //clickLkmUI.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    inv.plusObjCamera();
                    Destroy(hit.collider.gameObject);
                }
            }

            if(hit.collider.tag == "KEY")
            {
                if(Input.GetMouseButtonDown(0))
                {
                    inv.plusObjKey();
                    Destroy(hit.collider.gameObject);
                }
            }

            if(hit.collider.tag == "doorKillOwner")
            {
                clickLkmUI.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    level = 1;
                    PlayerPrefs.SetInt("level", level);
                    SceneManager.LoadScene("KatSceneKillOwner");
                }
            }

            if(hit.collider.tag == "door")
            {
                //clickLkmUI.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    //hit.collider.GetComponent<Door>().openOrCloose();
                    hit.collider.GetComponent<Door>().openOrCloseDoor();
                }
            }

            if(hit.collider.tag == "wardrobe")
            {
                clickLkmUI.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    hit.collider.GetComponent<Wardrobe>().openOrCloose();
                }
            }

            if(hit.collider.tag == "stone")
            {
                clickLkmUI.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    if(haveAxe)
                    {
                        hit.collider.GetComponent<stone>().health -= 20;
                        Instantiate(soundStone);
                        gameObject.GetComponent<PlayerMovementGAME>().isActiveAudio = true;
                    }
                }
            }

            if(hit.collider.tag == "shelf")
            {
                Debug.Log("есть че то");
                //clickLkmUI.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    animationHands.SetActive(true);
                    animationHands.GetComponent<Animator>().Play("animationHand");
                    hit.collider.GetComponent<ShelfZam>().doing();
                    //Instantiate(soundOpenDoorShelf);
                    gameObject.GetComponent<PlayerMovementGAME>().isActiveAudio = true;
                }
            }
        }
    }



    #region VOID and IE
        private void OnTriggerEnter(Collider obj)
        {
            if(obj.gameObject.tag == "tagActiveEnemy")
            {
                enemy.SetActive(true);
                    #region SOUND
                        Instantiate(soundActiveEnemy);
                    #endregion
                level = 2;
                PlayerPrefs.SetInt("level", level);
                Destroy(obj.gameObject);
            }
            if(obj.gameObject.tag == "pictureTag")
            {
                level = 4;
                PlayerPrefs.SetInt("level", level);
            }
            if(obj.gameObject.tag == "roomRitual")
            {
                level = 5;
                PlayerPrefs.SetInt("level", level);
            }
        }
    #endregion
}