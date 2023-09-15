using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetObjectToInventory : MonoBehaviour
{   
    public GameManager gm;
    public string itemTag; 

    private bool isCollected = false;

    private void OnMouseDown()
    {
        if (gameObject.CompareTag(itemTag))
        {
            if (itemTag == "Knife")
            {
                GameManager.Instance.isKnifeCollected = true;
            }

            if (itemTag == "Frame")
            {
                GameManager.Instance.frame.SetActive(true);
                GameManager.Instance.isFrameOpen=true;
            }

            if (itemTag == "Corpse")
            {
                if(GameManager.Instance.isKnifeCollected)
                {
                    GameManager.Instance.EndGameScreen.SetActive(true);
                }
            }

            Destroy(gameObject);
        }
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            OnMouseDown();
            
            if(GameManager.Instance.isFrameOpen)
            {
                GameManager.Instance.frame.SetActive(false);
            }
        }

    }

}
