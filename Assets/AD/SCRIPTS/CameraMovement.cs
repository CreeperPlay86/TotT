using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    #region DATA
        #region FLOAT
            public float xRot;
	        public float yRot;	
	        public float xRotCurrent;
	        public float yRotCurrent;
	        public float smoothTime;
	        public float currentVelocityX;
	        public float currentVelocityY;

            public float sensivity;

            public float yPos;
        #endregion

        #region GAME OBJECTS
            public Camera me;	
	        public GameObject playerGameObject;
        #endregion

    #endregion

    void Start()
    {
        smoothTime = 0.1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	void FixedUpdate()
	{
		xRot += Input.GetAxis("Mouse X") * sensivity ;
		yRot += Input.GetAxis("Mouse Y") * sensivity ;
		yRot = Mathf.Clamp(yRot, -15, 5);

		xRotCurrent = Mathf.SmoothDamp(xRotCurrent, xRot, ref currentVelocityX, smoothTime);
		yRotCurrent = Mathf.SmoothDamp(yRotCurrent, yRot, ref currentVelocityY, smoothTime);
		me.transform.rotation = Quaternion.Euler(-(yRotCurrent - 41.125f), xRotCurrent, 0f);
		playerGameObject.transform.rotation = Quaternion.Euler(0f, xRotCurrent, 0f);

        
        //transform.position = new Vector3(transform.position.x, )
	}
}
