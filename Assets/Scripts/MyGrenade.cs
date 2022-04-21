using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;


    public class MyGrenade : MonoBehaviour
    {
        public PlayerController playerController;
        public GameObject explodePartPrefab;
        public int explodeCount = 0;
        public AudioSource flash;
    public AudioSource ring;



        public float minMagnitudeToExplode = 1f;

        private Interactable interactable;

        private void Start()
        {
            interactable = this.GetComponent<Interactable>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (interactable != null && interactable.attachedToHand != null) //don't explode in hand
                return;

            if (collision.impulse.magnitude > minMagnitudeToExplode)
            {
            flash.Play();
            for (int explodeIndex = 0; explodeIndex < explodeCount; explodeIndex++)
                {
                    GameObject explodePart = (GameObject)GameObject.Instantiate(explodePartPrefab, this.transform.position, this.transform.rotation);
                    explodePart.GetComponentInChildren<MeshRenderer>().material.SetColor("_TintColor", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
                    
 
                }

                Destroy(this.gameObject);

                playerController.grenadeCount += 1;
                if(playerController.grenadeCount > 2)
            {

                playerController.chapter = 2;
            }
            }
        }
    }
