using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
	#endregion

    void FixedUpdate()
    {
        Move();

		Debug.Log("не ломай компас :'( ");
    }

    void Start()
    {
        player = GetComponent<CharacterController>();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void Move()
	{
		x_Move = Input.GetAxis("Horizontal");
		z_Move = Input.GetAxis("Vertical");

		if(x_Move != 0 || z_Move != 0)
		{
			run.SetActive(true);
			idle.SetActive(false);
			if(!Input.GetKey(KeyCode.LeftShift))
			{
				//if(player.isGrounded)
				//	audioStep.SetActive(true);
				//else
				//	audioStep.SetActive(false);
				
			}
			//else
				//audioStep.SetActive(false);
		}
		else
		{
			run.SetActive(false);
			idle.SetActive(true);
			//audioStep.SetActive(false);
			//audioRun.SetActive(false);
		}
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
		if(Input.GetKey(KeyCode.LeftShift))
		{
		 	speed_Current = speed_Run;
			//staminaBar.GetComponent<
			//if(player.isGrounded)
			//	audioRun.SetActive(true);
			//else
			//	audioRun.SetActive(false);
		}
		else
		{
			speed_Current = speed_Move;
			//audioRun.SetActive(false);
		}
		player.Move(move_Direction * speed_Current * Time.deltaTime);
	}
}
