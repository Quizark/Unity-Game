using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    bool doorIsOpen = false;
    GameObject currentDoor;
    float doorTimer = 0.0f;
    public float doorOpenTime = 3.0f;
    public AudioClip doorOpenSound;
    public AudioClip doorShutSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpen)
        {
            doorTimer += Time.deltaTime;
            if (doorTimer > doorOpenTime)
            {
                Door(doorShutSound, false, "doorshut");
                doorTimer = 0.0f;
            }
        }
    }
    //void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false)
    //    {
    //        currentDoor = hit.gameObject;
    //        Door(currentDoor);
    //    }
    // }
    //void OpenDoor(GameObject door)
    //{
    //    doorIsOpen = true;
    //    door.GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
    // door.transform.parent.GetComponent<Animation>().Play("dooropen");
    //    }
    //void ShutDoor(GameObject door)
    //{
    //   doorIsOpen = false;
    //   door.GetComponent<AudioSource>().PlayOneShot(doorShutSound);
    //   door.transform.parent.GetComponent<Animation>().Play("doorshut");
    // }
    void Door(AudioClip aClip, bool openCheck, string animName)
    {
        if (!doorIsOpen)
        {
            doorIsOpen = true;
            this.GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
            this.transform.parent.GetComponent<Animation>().Play("dooropen");
        }
        else
        {
            doorIsOpen = false;
            this.GetComponent<AudioSource>().PlayOneShot(doorShutSound);
            this.transform.parent.GetComponent<Animation>().Play("doorshut");
        }

    }

    void DoorCheck()
    {
        if (!doorIsOpen)
        {
            Door(doorOpenSound, true, "dooropen");
        }
    }
}
