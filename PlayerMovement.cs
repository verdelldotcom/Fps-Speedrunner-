using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour {
    
    float forward_movment;
    float strafe_movement;
    Vector3 movement;

    [SerializeField]
    float speed;
    
    CharacterController _characterController;
    
    void Start() {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update() {
        
        strafe_movement = (Input.GetAxis("Horizontal") * speed) * Time.deltaTime;
        forward_movment = (Input.GetAxis("Vertical") * speed) * Time.deltaTime;

        movement = transform.right * strafe_movement + transform.forward * forward_movment;

        _characterController.Move(motion: movement);
    }
}
