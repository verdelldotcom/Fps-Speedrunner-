using UnityEngine;

public class CameraMovement : MonoBehaviour {
    
    float x_rotation;
    float y_rotation;
    
    [SerializeField]
    Transform player_trasnfrom;

    void Start() {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    void Update() {
        transform.position = player_trasnfrom.position;
        
        x_rotation += Input.GetAxis(axisName: "Mouse X");
        y_rotation += Input.GetAxis(axisName: "Mouse Y");

        y_rotation = Mathf.Clamp(value: y_rotation,min: -60,max:60);

        transform.rotation = Quaternion.Euler(x: -y_rotation, y: x_rotation, z: 0);
        player_trasnfrom.transform.rotation = Quaternion.Euler(x: 0, y: x_rotation, 0);
    }
}
