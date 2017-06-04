using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{

    

    private GameObject earth;
    private GameObject atom;
    private GameObject bubbles;
    private GameObject buckyball;
    public int state = 0;
    // Use this for initialization
    void Start()
    {
        
        earth = GameObject.Find("earth");
        atom = GameObject.Find("AtomBall");
        bubbles = GameObject.Find("Bubbles");
        buckyball = GameObject.Find("BuckyBall");

       

        earth.SetActive(true);
        atom.SetActive(false);
        bubbles.SetActive(false);
        buckyball.SetActive(false);
    }
    
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("BUTTON BITCH!");
       

    }
    
    // Update is called once per frame
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
    

    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)== true)
        {
            if (state == 0)
            {
                earth.SetActive(true);
                atom.SetActive(false);
                bubbles.SetActive(false);
                buckyball.SetActive(false);
                state = 3;
            }
            else if (state == 1)
            {
                earth.SetActive(false);
                atom.SetActive(true);
                bubbles.SetActive(false);
                buckyball.SetActive(false);
                state = 0;
            }
            else if (state == 2)
            {
                earth.SetActive(false);
                atom.SetActive(false);
                bubbles.SetActive(true);
                buckyball.SetActive(false);
                state = 1;
            }
            else if (state == 3)
            {
                earth.SetActive(false);
                atom.SetActive(false);
                bubbles.SetActive(false);
                buckyball.SetActive(true);
                state = 2;
            }
        }
    }
}
