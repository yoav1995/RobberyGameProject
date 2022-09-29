using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController cController;
    public float rotationAroundY = 0;
    public float rotationAroundX = 0;
    public float angularSpeed = 20;
    float speed = 5.25f;
    public GameObject aCamera; // public means that it must be connected to some object in Unity
    // Start is called before the first frame update
    AudioSource sound;
    void Start()
    {
        cController = GetComponent<CharacterController>();//conect to character contrller of player
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaz;
        float deltax;

        rotationAroundX = -1 * Input.GetAxis("Mouse Y") * angularSpeed * Time.deltaTime;
        // rotates only camera
        aCamera.transform.Rotate(new Vector3(rotationAroundX, 0, 0));

  

        rotationAroundY = Input.GetAxis("Mouse X") * angularSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, rotationAroundY, 0));

        // Time.deltaTime is time btween frames
        deltaz = speed * Input.GetAxis("Vertical") * Time.deltaTime; // can be {1,0,-1}
        deltax = speed * Input.GetAxis("Horizontal") * Time.deltaTime; // can be {1,0,-1}

        Vector3 motion = new Vector3(deltax, -0.5f, deltaz);// always forward in Local coordinates
     
        motion = transform.TransformDirection(motion); // transforms motion to GLOBAL coordinates
        cController.Move(motion);// gets vector in GLOBAL coordinates

        //when the player moves and the sound is not playing
        if (((deltaz >0.01|| deltaz<-0.01) || (deltax > 0.01 || deltax < -0.01)) &&!sound.isPlaying)
            sound.Play();


        
        //  Vector3 motion = new Vector3(0, deltax ,- 0.5f);// always forward in Local coordinates
        // simple motion of player to z axis
        // transform.position += new Vector3(0,0,0.05f);

    }
}
