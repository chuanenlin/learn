using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButtonObject;
    private GameObject vbButtonUp;
    private GameObject vbButtonDown;
    private GameObject vbButtonLeft;
    private GameObject vbButtonRight;
 
    private GameObject pet2;
    public int x = 1;
    public int pressed= 0;
    public int state = 0;
    // Use this for initialization
    void Start()
    {
        vbButtonObject = GameObject.Find("lft");
        vbButtonUp = GameObject.Find("u");
        vbButtonDown = GameObject.Find("d");
        vbButtonLeft = GameObject.Find("l");
        vbButtonRight = GameObject.Find("r");
        state = 0;
        //VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();



        pet2 = GameObject.Find("elf");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vbButtonUp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vbButtonDown.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vbButtonLeft.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vbButtonRight.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
        pet2.SetActive(false);
        //pet2.SetActive(true);
    }
    

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {

        pressed = 1;
        if (vb.VirtualButtonName == "lft")
        {
            Debug.Log("Button!!");

            //pet.GetComponent<Animation>().Play();
            pet2.GetComponent<Animation>().Play();
            if (x == 1)
            {

                pet2.SetActive(true);
                x = 0;
            }
            else if (x == 0)
            {

                pet2.SetActive(false);
                x = 1;
            }


        }
        
       
        
      
           
            if (vb.VirtualButtonName == "u")
            {
                Debug.Log("Button2!!");
                //pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 1000, 0));

                if(state == 3)
                {
                    pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 5500, 0));
                }
                if (state == 4)
                {
                    pet2.transform.Rotate(new Vector3(0, -1*Time.deltaTime * 5500, 0));
                }
                if (state == 2)
                {
                    pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 11000, 0));
                }

                pet2.transform.Translate(new Vector3(0, 0, Time.deltaTime * 200));
                //left 5500, right -5500, down 11000
           

                state = 1;

            }
            if (vb.VirtualButtonName == "d")
            {
                Debug.Log("Button3!!");
                //pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 1000, 0));

                
            //left -5500, right 5500, up 11000
                if (state == 4)
                {
                    pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 5500, 0));
                }
                if (state == 3)
                {
                    pet2.transform.Rotate(new Vector3(0, -1 * Time.deltaTime * 5500, 0));
                }
                if (state == 1)
                {
                    pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 11000, 0));
                }
                state = 2;
                pet2.transform.Translate(new Vector3(0, 0, Time.deltaTime * 200));
        }

            if (vb.VirtualButtonName == "l")
            {
                Debug.Log("Button4!!");
            //pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 1000, 0));
                if (state == 2)
                {
                    pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 5500, 0));
                }
                if (state == 1)
                {
                    pet2.transform.Rotate(new Vector3(0, -1 * Time.deltaTime * 5500, 0));
                }
                if (state == 4)
                {
                    pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 11000, 0));
                }

                pet2.transform.Translate(new Vector3(0, 0,  Time.deltaTime * 200));
                //up -5500, down 5500, right 11000
                state = 3;
            }
            if (vb.VirtualButtonName == "r")
            {
                Debug.Log("Button5!!");
                if (state == 1)
                {
                    pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 5500, 0));
                }
                if (state == 2)
                {
                    pet2.transform.Rotate(new Vector3(0, -1 * Time.deltaTime * 5500, 0));
                }
                if (state == 3)
                {
                    pet2.transform.Rotate(new Vector3(0, Time.deltaTime * 11000, 0));
                }
                pet2.transform.Translate(new Vector3(0, 0, Time.deltaTime * 200));
                //up 5500, down 5500, left 11000
                state = 4;
            }
        
        



    }
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        //zombie.SetActive(false);
        //zombie.GetComponent<Animation>().Stop();
        //zombie.SetActive(false);
        //pet.SetActive(false);
        pressed = 0;
    }


}
