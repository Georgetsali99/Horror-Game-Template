using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_imput : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Camera_screen;

    public Material camera1_tex;
    public Material camera2_tex;
    public Material camera3_tex;
    public Material camera4_tex;
    public Material camera5_tex;
    public Material camera6_tex;
    public Material camera7_tex;
    public int camera_num=0;
    void Start()
    {
        camera_num=0;
    }
    // Update is called once per frame
    void Update()
    {
          if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "Camera_view")
                {
                    camera_num=camera_num+1;
                    if(camera_num==1){
                        Camera_screen.GetComponent<Renderer>().material= camera1_tex;
                        Debug.Log("cam1");
                        
                    }
                    else if(camera_num==2){     
                        Camera_screen.GetComponent<Renderer>().material= camera2_tex;
                        Debug.Log("cam2");
                        
                    }
                    else if(camera_num==3){     
                        Camera_screen.GetComponent<Renderer>().material= camera3_tex;
                        Debug.Log("cam3");
                        
                    }
                    else if(camera_num==4){     
                        Camera_screen.GetComponent<Renderer>().material= camera4_tex;
                        Debug.Log("cam4");
                        
                    }
                    else if(camera_num==5){     
                        Camera_screen.GetComponent<Renderer>().material= camera5_tex;
                        Debug.Log("cam5");
                        
                    }
                    else if(camera_num==6){     
                        Camera_screen.GetComponent<Renderer>().material= camera6_tex;
                        Debug.Log("cam6");
                        
                    }
                    else if(camera_num==7){     
                        Camera_screen.GetComponent<Renderer>().material= camera7_tex;
                        Debug.Log("cam7");
                        
                    }
                    else{
                    camera_num=0;
                    }
                    Debug.Log("screen");
                }
            }
        }
    }
}
