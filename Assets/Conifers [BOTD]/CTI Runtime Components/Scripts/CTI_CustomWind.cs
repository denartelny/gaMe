using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace CTI {

	[RequireComponent (typeof (WindZone))]
	public class CTI_CustomWind : MonoBehaviour {

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Water") {
                SceneManager.LoadScene("Scene");
            }
          
        }



    }
}