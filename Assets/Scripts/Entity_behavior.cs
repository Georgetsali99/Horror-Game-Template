using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity_behavior : MonoBehaviour
{
    public GameObject Entity_pos_0;
    public GameObject Entity_pos_1;
    public GameObject Entity_pos_2;
    public GameObject Entity_pos_3;
    public GameObject Entity_pos_4;
    public GameObject Entity_pos_5;
    public GameObject Entity_pos_6;
    public GameObject Entity_pos_7;

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;
    public Light light6;
    public Light light7;

    public GameObject Camera_screen;
    public Mouse_imput camera_num_INPUT;

    public Material camera1_tex;
    public Material camera2_tex;
    public Material camera3_tex;
    public Material camera4_tex;
    public Material camera5_tex;
    public Material camera6_tex;
    public Material camera7_tex;

    float timer;
    float numb=3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //-------------------------------------------camera 1---------------------------------------------- 
        if(camera_num_INPUT.camera_num == 1 && Entity_pos_1.GetComponent<Renderer>().enabled == true)
        {
            Debug.Log("cam1_ent");

            if(Input.GetKeyDown(KeyCode.E))
            {
                light1.GetComponent<Light>().enabled = true;
                timer=Time.time;
                Debug.Log("e");
            }
            else if(Input.GetKey(KeyCode.E))
            {
               
                if (Time.time - timer> numb)
                {
                    light1.GetComponent<Light>().enabled = false;
                    Debug.Log("2");
                    timer= float.PositiveInfinity;
                    Entity_pos_1.GetComponent<Renderer>().enabled = false;
                    Entity_pos_0.GetComponent<Renderer>().enabled = true;
                }
            }
            else
            {
                 if(Input.GetKeyUp(KeyCode.E))
                {
                     Debug.Log("out");
                    light1.GetComponent<Light>().enabled = false;
                }
                timer= float.PositiveInfinity;
            }
        }

        //-------------------------------------------camera 2----------------------------------------------
        else if(camera_num_INPUT.camera_num == 2 && Entity_pos_2.GetComponent<Renderer>().enabled == true)
        {
            Debug.Log("cam2_ent");
           if(Input.GetKeyDown(KeyCode.E))
            {
                light2.GetComponent<Light>().enabled = true;
                timer=Time.time;
                Debug.Log("e");
            }
            else if(Input.GetKey(KeyCode.E))
            {
               
                if (Time.time - timer> numb)
                {
                    light2.GetComponent<Light>().enabled = false;
                    Debug.Log("2");
                    timer= float.PositiveInfinity;
                    Entity_pos_2.GetComponent<Renderer>().enabled = false;
                    Entity_pos_1.GetComponent<Renderer>().enabled = true;
                }
            }
            else
            {
                 if(Input.GetKeyUp(KeyCode.E))
                {
                     Debug.Log("out");
                    light2.GetComponent<Light>().enabled = false;
                }
                timer= float.PositiveInfinity;
            }
                
            
        }

        //-------------------------------------------camera 3----------------------------------------------
        else if(camera_num_INPUT.camera_num == 3 && Entity_pos_3.GetComponent<Renderer>().enabled == true)
        {
            Debug.Log("cam3_ent");
           if(Input.GetKeyDown(KeyCode.E))
            {
                light3.GetComponent<Light>().enabled = true;
                timer=Time.time;
                Debug.Log("e");
            }
            else if(Input.GetKey(KeyCode.E))
            {
               
                if (Time.time - timer> numb)
                {
                    light3.GetComponent<Light>().enabled = false;
                    Debug.Log("3");
                    timer= float.PositiveInfinity;
                    Entity_pos_3.GetComponent<Renderer>().enabled = false;
                    Entity_pos_1.GetComponent<Renderer>().enabled = true;
                }
            }
            else
            {
                 if(Input.GetKeyUp(KeyCode.E))
                {
                     Debug.Log("out");
                    light3.GetComponent<Light>().enabled = false;
                }
                timer= float.PositiveInfinity;
            }
        }
        //-------------------------------------------camera 4----------------------------------------------
        else if(camera_num_INPUT.camera_num == 4 && Entity_pos_4.GetComponent<Renderer>().enabled == true)
        {
            Debug.Log("cam4_ent");
           if(Input.GetKeyDown(KeyCode.E))
            {
                light4.GetComponent<Light>().enabled = true;
                timer=Time.time;
                Debug.Log("e");
            }
            else if(Input.GetKey(KeyCode.E))
            {
               
                if (Time.time - timer> numb)
                {
                    light4.GetComponent<Light>().enabled = false;
                    Debug.Log("4");
                    timer= float.PositiveInfinity;
                    Entity_pos_4.GetComponent<Renderer>().enabled = false;
                    Entity_pos_3.GetComponent<Renderer>().enabled = true;
                }
            }
            else
            {
                 if(Input.GetKeyUp(KeyCode.E))
                {
                     Debug.Log("out");
                    light4.GetComponent<Light>().enabled = false;
                }
                timer= float.PositiveInfinity;
            }   
        }         
         //-------------------------------------------camera 5----------------------------------------------
        else if(camera_num_INPUT.camera_num == 5 && Entity_pos_5.GetComponent<Renderer>().enabled == true)
        {
            Debug.Log("cam5_ent");
           if(Input.GetKeyDown(KeyCode.E))
            {
                light5.GetComponent<Light>().enabled = true;
                timer=Time.time;
                Debug.Log("e");
            }
            else if(Input.GetKey(KeyCode.E))
            {
               
                if (Time.time - timer> numb)
                {
                    light5.GetComponent<Light>().enabled = false;
                    Debug.Log("5");
                    timer= float.PositiveInfinity;
                    Entity_pos_5.GetComponent<Renderer>().enabled = false;
                    Entity_pos_4.GetComponent<Renderer>().enabled = true;
                }
            }
            else
            {
                 if(Input.GetKeyUp(KeyCode.E))
                {
                     Debug.Log("out");
                    light5.GetComponent<Light>().enabled = false;
                }
                timer= float.PositiveInfinity;
            }    
        }

         //-------------------------------------------camera 6----------------------------------------------
        else if(camera_num_INPUT.camera_num == 6 && Entity_pos_6.GetComponent<Renderer>().enabled == true)
        {
            Debug.Log("cam6_ent");
           if(Input.GetKeyDown(KeyCode.E))
            {
                light6.GetComponent<Light>().enabled = true;
                timer=Time.time;
                Debug.Log("e");
            }
            else if(Input.GetKey(KeyCode.E))
            {
               
                if (Time.time - timer> numb)
                {
                    light6.GetComponent<Light>().enabled = false;
                    Debug.Log("6");
                    timer= float.PositiveInfinity;
                    Entity_pos_6.GetComponent<Renderer>().enabled = false;
                    Entity_pos_5.GetComponent<Renderer>().enabled = true;
                }
            }
            else
            {
                 if(Input.GetKeyUp(KeyCode.E))
                {
                     Debug.Log("out");
                    light6.GetComponent<Light>().enabled = false;
                }
                timer= float.PositiveInfinity;
            }    
        }
        //-------------------------------------------camera 7----------------------------------------------
        else if(camera_num_INPUT.camera_num == 7 && Entity_pos_7.GetComponent<Renderer>().enabled == true)
        {
            Debug.Log("cam7_ent");
           if(Input.GetKeyDown(KeyCode.E))
            {
                light6.GetComponent<Light>().enabled = true;
                timer=Time.time;
                Debug.Log("e");
            }
            else if(Input.GetKey(KeyCode.E))
            {
               
                if (Time.time - timer> numb)
                {
                    light6.GetComponent<Light>().enabled = false;
                    Debug.Log("7");
                    timer= float.PositiveInfinity;
                    Entity_pos_7.GetComponent<Renderer>().enabled = false;
                    Entity_pos_4.GetComponent<Renderer>().enabled = true;
                }
            }
            else
            {
                 if(Input.GetKeyUp(KeyCode.E))
                {
                     Debug.Log("out");
                    light7.GetComponent<Light>().enabled = false;
                }
                timer= float.PositiveInfinity;
            }
        }
        else
        {
           Debug.Log("end"); 
        }
    }
    
}
