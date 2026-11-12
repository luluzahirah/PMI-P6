using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start () {
        
    }
    
    void OnMouseDown() {
        if (gameObject.name == "tombol kiri") {

        }
        else if (gameObject.name == "tombol kanan") {

        }
        else if (gameObject.name == "tombol loncat") {
            player.GetComponent<player>().melompat();
        }
    }

    void OnMouseUp() {
        if (gameObject.name == "tombol kiri") {
            player.GetComponent<player>().berhenti();
        }
        else if (gameObject.name == "tombol kanan") {
            player.GetComponent<player>().berhenti();
        }
        else if (gameObject.name == "tombol loncat") {

        }
    }

    void OnMouseDrag() {
        if (gameObject.name == "tombol kiri") {
            player.GetComponent<player>().jalan_kiri();
        }
        else if (gameObject.name == "tombol kanan") {
            player.GetComponent<player>().jalan_kanan();
        }
        else if (gameObject.name == "tombol loncat") {

        }
    }

    // Update is called once per frame
    void Update () {
        
    }
}