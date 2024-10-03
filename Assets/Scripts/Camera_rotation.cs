using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera_rotation : MonoBehaviour
{
    public GameObject MainCamera;
    public float Target;
    float r;


  
    // Start is called before the first frame update
    void Start()
    {

    }
    public void change_camera_rotation(float AngleTarget)
    {
       Target = AngleTarget;
    }
    // Update is called once per frame
    void Update()
    {
        Quaternion currentRot = transform.rotation;
        Quaternion targetRot = Quaternion.Euler(0,Target,0);
       MainCamera.transform.rotation= Quaternion.Slerp(currentRot,targetRot,0.1f);

    }
}
