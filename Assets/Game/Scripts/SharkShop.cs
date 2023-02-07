using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkShop : MonoBehaviour
{
    [SerializeField]
    private AudioClip _winSound;
    private UIManager _uiManager;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player player = other.GetComponent<Player>();
                if (player != null)
                {
                    if(player.hasCoin == true)
                    {
                        player.hasCoin = false;
                        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
                        if (_uiManager != null)
                        {
                            _uiManager.useStoreCoin();
                            AudioSource.PlayClipAtPoint(_winSound, transform.position, 1f);
                            player.EnableWeapon();
                            Debug.Log("Gracias por la compra. Ten tu arma");
                        }

                    }
                    else
                    {
                        Debug.Log("No tenes plata. Por favor volvé cuando tengas.");
                    }
                }
            }
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
