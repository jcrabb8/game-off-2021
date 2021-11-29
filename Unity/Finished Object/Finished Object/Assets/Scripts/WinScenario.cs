using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScenario : MonoBehaviour
{
    
    public GameObject CraftButton;
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;
    public GameObject Slot6;
    public GameObject Slot7;
    public GameObject Slot8;
    public string nextScene;
    

    // Start is called before the first frame update
    void Start()
    {
        CraftButton.SetActive(false);
        Debug.Log(Slot1.transform.childCount);



    }


    void Update(){
        Debug.Log(Slot1.transform.childCount + 
            Slot2.transform.childCount + 
            Slot3.transform.childCount + 
            Slot4.transform.childCount + 
            Slot5.transform.childCount + 
            Slot6.transform.childCount + 
            Slot7.transform.childCount + 
            Slot8.transform.childCount);


        if (Slot1.transform.childCount + 
            Slot2.transform.childCount + 
            Slot3.transform.childCount + 
            Slot4.transform.childCount + 
            Slot5.transform.childCount + 
            Slot6.transform.childCount + 
            Slot7.transform.childCount + 
            Slot8.transform.childCount > 3){
            CraftButton.SetActive (true);
        }
        else{
            CraftButton.SetActive (false);
        }

    }

    //public void clickThisButton()
     //{
       //    CraftButton.SetActive (true);

     //}


    public void NextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

}
