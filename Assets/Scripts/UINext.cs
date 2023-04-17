using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINext : MonoBehaviour
{
    public bool isShowingNext; 
    public bool somethingNext;
    public bool isNextObject;
    public bool shop;
    
    //public bool isTheNext;
    //public GameObject Previous;
    public GameObject nextObj;
    public GameObject prevObj; 


    void Start()
    {
        isShowingNext = false; 
    }
    // Update is called once per frame
    void OnDisable()
    {
        //this.isShowingNext = false; 
    }
    public void backButton()
    {
        Debug.Log("backbutton pressed");
        this.gameObject.SetActive(false);
        Debug.Log(this.gameObject);
    }



    void Update()
    {
        if (!shop)
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (!somethingNext)
                {

                    if (isNextObject)
                    {
                        prevObj.GetComponent<UINext>().isShowingNext = false;

                    }
                    isShowingNext = false;
                    this.gameObject.SetActive(false);

                }
                else if (somethingNext)
                {
                    if (!isNextObject)
                    {
                        isShowingNext = true;
                        this.gameObject.SetActive(false);
                        nextObj.SetActive(true);
                    }




                }
            }
        }
       
    }
}
