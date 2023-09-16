using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetObjectToInventory : MonoBehaviour
{   
    public GameManager gm;
    public string itemTag; 


        public void CollectObject(string itemTag)
        {
            Debug.Log("CollectObject called with tag: " + itemTag); // Add this line for debugging

            if (itemTag == "Knife")
            {
                Debug.Log("Knife Collection Activted");
                GameManager.Instance.isKnifeCollected = true;
                Destroy(gameObject);
            }

            if (itemTag == "Frame")
            {
                GameManager.Instance.frame.SetActive(true);
                GameManager.Instance.isFrameOpen = true;
            }

            if (itemTag == "Corpse")
            {
                if (GameManager.Instance.isKnifeCollected)
                {
                    GameManager.Instance.EndGameScreen.SetActive(true);
                }
            }

                    if(GameManager.Instance.isFrameOpen)
                    {
                        GameManager.Instance.frame.SetActive(false);
                    }

            
        }

}
