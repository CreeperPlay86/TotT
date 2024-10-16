using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementGAME : MonoBehaviour 
{ 
    #region DATA 
  		#region FLOAT 
   			public float speed_Move; 
   			public float speed_Run; 
   			public float speed_Current; 
   			public float jump; 
   			public float gravity;  
   			public float m_FieldOfView; 
   			public float x_Move; 
   			public float z_Move; 
  		#endregion 
   
  		#region VECTOR  
   			CharacterController player;  
   			Vector3 move_Direction; 
  		#endregion 
 
  		#region audio 
   			public GameObject audioStep; 
   			public GameObject audioRun; 
  		#endregion 
 
  		#region GAME OBJECTS || UI 
   			public GameObject staminaBar; 
 
   			public GameObject idle; 
   			public GameObject run; 
  		#endregion 
 
  		#region BOOL 
   			public bool onTheCarpet; 

			public bool isActiveAudio;
  		#endregion 
 	#endregion 
 
    void FixedUpdate() 
    { 
        Move(); 
    } 
 
    void Start() 
    { 
        player = GetComponent<CharacterController>(); 
        Cursor.lockState = CursorLockMode.Locked; 
    } 
 
    public void Move() 
 	{ 
  		x_Move = Input.GetAxis("Horizontal"); 
  		z_Move = Input.GetAxis("Vertical"); 
 
 
        #region SOUND 
      		if(x_Move != 0 || z_Move != 0) 
      		{ 
       			if(Input.GetKey(KeyCode.LeftShift)) 
       			{ 
     				speed_Current = speed_Run; 
        			if(player.isGrounded) 
        			{ 
      					if(!onTheCarpet) 
      					{ 
      					 	audioRun.SetActive(true); 
      					 	audioStep.SetActive(false); 
							isActiveAudio = true;
      					} 
      					else 
      					{ 
							isActiveAudio = false;
      					 	audioStep.SetActive(false); 
      					 	audioRun.SetActive(false);  
      					} 
     				} 
        			else 
        			{ 
						isActiveAudio = false;
      					audioRun.SetActive(false); 
      					audioStep.SetActive(false); 
     				} 
  
       			} 
       			else 
       			{ 
     				speed_Current = speed_Move; 
     				if(!onTheCarpet) 
     				{ 
						isActiveAudio = true;
     				 	audioStep.SetActive(true); 
     				 	audioRun.SetActive(false);  
     				} 
     				else 
     				{ 
						isActiveAudio = false;
     				 	audioStep.SetActive(false); 
     				 	audioRun.SetActive(false);  
     				} 
    			} 
      		} 
      		else 
      		{ 
				isActiveAudio = false;
       			audioStep.SetActive(false); 
       			audioRun.SetActive(false); 
      		} 
 
        #endregion 
 
  	if(player.isGrounded) 
  	{ 
   		move_Direction = new Vector3(x_Move, 0f, z_Move).normalized; 
   		move_Direction = transform.TransformDirection(move_Direction); 
	
   		if(Input.GetKey(KeyCode.Space)) 
   		{ 
    		move_Direction.y += jump; 
   		} 
  	} 
  		move_Direction.y -= gravity; 
  		player.Move(move_Direction * speed_Current * Time.deltaTime); 
 	} 
 
 
 	#region SOUND 
  		public void OnTriggerStay(Collider obj) 
  		{ 
   			if(obj.gameObject.tag == "carpet") 
   			{ 
    			onTheCarpet = true; 
   			} 
   			if(obj.gameObject.tag == "regionNoEffectCarpet") 
   			{ 
    			onTheCarpet = false; 
			}
  		} 
 	#endregion 
}