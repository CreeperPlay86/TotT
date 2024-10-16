using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{   
    public Animator Anim;
    public bool DoorClosed = false;

    public bool goAnimation;

    public bool KDanim;

    public bool KDpatrol;

    public bool activeAudioDoor;

    public GameObject soundOpenDoor;

    public GameObject enemy;

    public float distance;

    void Start(){

        Anim.Play("CloseDoor");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update(){

        if(goAnimation)
        {
            if(KDanim)
                return;
            activeAudioDoor = true;
            KDanim = true;
            goAnimation = false;
            StartCoroutine(KdAnimation());
            if(DoorClosed)
            {
                DoorClosed = false;
                Anim.Play("OpenDoor");

            }
            if(!DoorClosed)
            {
                DoorClosed = true;
                Anim.Play("CloseDoor");

            }
        }

        distance = Vector3.Distance(transform.position, enemy.transform.position);

        if(enemy.GetComponent<EnemyAIGame>().indexChase == 1)
        {
            enemy.GetComponent<EnemyAIGame>().objIsDown = false;
        }
        if(distance <= 2f && activeAudioDoor)
        {
            activeAudioDoor = false;
            if(KDpatrol)
                return;
            if(enemy.GetComponent<EnemyAIGame>().numberTarget >= 5)
                enemy.GetComponent<EnemyAIGame>().numberTarget = 0;
            else
                enemy.GetComponent<EnemyAIGame>().numberTarget++;
            enemy.GetComponent<EnemyAIGame>().objIsDown = false;
            StartCoroutine(goKD());
        }
    }

    public void openOrCloseDoor()
    {
        Instantiate(soundOpenDoor);
        if(!(enemy.GetComponent<EnemyAIGame>().target == enemy.GetComponent<EnemyAIGame>().Player))
        {
            enemy.GetComponent<EnemyAIGame>().target = gameObject.transform;
            enemy.GetComponent<EnemyAIGame>().objIsDown = true;
        }
        goAnimation = true;
    }

    IEnumerator KdAnimation()
    {
        yield return new WaitForSeconds(1.05f);
        KDanim = false;
    }

    IEnumerator goKD()
    {
        KDpatrol = true;
        yield return new WaitForSeconds(4f);
        KDpatrol = false;
    }

 //   #region DATA
 //       public bool isOpen;
//
 //       public bool goCloose;
 //       public bool goOpen;
//
 //       public bool kdAnimation;
//
 //       public float rotationY;
 //   #endregion
//
 //   public void openOrCloose()
 //   {
 //       if(!isOpen)
 //       {
 //           //if(kdAnimation)
 //           //    return;
 //           StartCoroutine(KDAnimation());
 //           StartCoroutine(KDclose());
 //           isOpen = true;
 //           goOpen = true;
 //           Debug.Log(goOpen);
 //           kdAnimation = true;
 //       }
 //       else
 //       {
 //           if(kdAnimation)
 //               return;
 //           StartCoroutine(KDAnimation());
 //           StartCoroutine(KDclose());
 //           isOpen = false;
 //           goCloose = true;
 //           kdAnimation = true;
 //       }
 //   }
//
 //   void Update()
 //   {
 //       if(Input.GetKeyDown(KeyCode.E))
 //       {
 //           //openOrCloose();
 //           Debug.Log("!");
 //           goOpen = true;
 //       }
 //       if(goCloose)
 //       {
 //           //if(transform.eulerAngles <= 180)
 //           //{
 //           //    rotationY +=(Time.deltaTime * 85);
 //           //    transform.eulerAngles  = Quaternion.Euler(transform.rotation.x, 63 + rotationY, transform.rotation.z);
 //           //    if(transform.rotation.y > 180)
 //           //    {
 //           //       kdAnimation = false; 
 //           //       goCloose = false;
 //           //    }
 //           //}
 //           //else
 //           //{
 //           //    kdAnimation = false; 
 //           //    goCloose = false;
 //           //}
//
 //           if(transform.rotation.y < 180)
 //           {
 //               transform.eulerAngles = new Vector3(0,179,0);
 //           }
 //       }
//
 //       if(goOpen)
 //       {
 //           //if(transform.rotation.y < 63)
 //           //{
 //           //    Debug.Log("чиназес");
 //           //    transform.rotation = Quaternion.Euler(transform.rotation.x, 180 - rotationY, transform.rotation.z);
 //           //    rotationY +=(Time.deltaTime * 85);
 //           //    if(transform.rotation.y < 63)
 //           //    {
 //           //       kdAnimation = false; 
 //           //       //goOpen = false;
 //           //    }
 //           //}
 //           //else
 //           //{
 //           //    kdAnimation = false; 
 //           //    //goOpen = false;
 //           //}
//
 //           //if(transform.rotation.y >= 179)
 //           //{
 //           //    transform.eulerAngles = new Vector3(0,63,0);
 //           //}
//
 //           Vector3 rotate = transform.eulerAngles;
 //           rotate.y = 63;
 //           transform.rotation = Quaternion.Euler(rotate);
 //       }
//
//
 //   }
//
 //   IEnumerator KDAnimation()
 //   {
 //       yield return new WaitForSeconds(0.94f);
 //       gameObject.GetComponent<Animator>().enabled = false;
 //       yield return new WaitForSeconds(0.2f);
 //       kdAnimation = false;
 //   }
//
 //   IEnumerator KDclose()
 //   {
 //       yield return new WaitForSeconds(1.375f);
 //       goCloose = false;
 //       goOpen = false;
 //       rotationY = 0;
 //   }
}
