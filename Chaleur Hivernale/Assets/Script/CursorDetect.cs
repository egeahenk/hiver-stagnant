using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CursorDetector : MonoBehaviour
{

    public GetObjectToInventory obj;
    


    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(worldPosition.x, worldPosition.y, transform.position.z);
    
        if (Input.GetKey(KeyCode.Mouse0)) // Mouse0 corresponds to the left mouse button
        {
            if (obj != null)
            {
                Debug.Log("Clicked object tag: " + gameObject.tag);
                obj.CollectObject(gameObject.tag);
                if(handleknife)
                {
                    Destroy(gameObject);
                    
                }
            }
        }
    }
bool handleknife = false;
            private void OnTriggerEnter(Collider other)
            {
                Debug.Log("Triggered object tag: " + other.gameObject.tag);
                if (other.gameObject.CompareTag("Knife"))
                {
                    handleknife = true;
                }
            }

}
