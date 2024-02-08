using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using System;

public class SetNavigationTarget3 : MonoBehaviour {
    [SerializeField]
    private TMP_Dropdown navigationTargetDropDown;
    [SerializeField]
    private List<Target> navigationTargetObjects = new List<Target>();
    [SerializeField]
    private TMP_Dropdown SelectFloor;
    
    private NavMeshPath path;
    private LineRenderer line;
    private Vector3 targetPosition = Vector3.zero;

    private bool lineToggle = true;

    private Scenes scene = new Scenes();
    public Camera topCamera;
    public Camera arCamera;

    private bool isArActive = true;
    private bool isMapActive = false;

    private void Start() {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
        line.enabled = lineToggle;
        arCamera.gameObject.SetActive(isArActive);
        topCamera.gameObject.SetActive(isMapActive);
    }

    private void Update() {
        if (lineToggle && targetPosition != Vector3.zero) {
            NavMesh.CalculatePath(transform.position, targetPosition, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
        }
    }

    public void SetCurrentNavigationTarget(int selectedValue) {
        targetPosition = Vector3.zero;
        string selectedText = navigationTargetDropDown.options[selectedValue].text;
        try {
            int value = Int32.Parse(selectedText);
            if (value >= 400) {
                Debug.Log("Перейдите на 4 этаж по лестнице");
            }
        } catch (FormatException) {
        }
        Target currentTarget = navigationTargetObjects.Find(x => x.Name.Equals(selectedText));
        if (currentTarget != null) {
            targetPosition = currentTarget.PositionObject.transform.position;
        }
    }

    public void Floor(int selectedValue) {
        string selectedText = SelectFloor.options[selectedValue].text;
        if (selectedText == "Floor1") {
            scene.OpenFloor1();
        }
        if (selectedText == "Floor2") {
            scene.OpenFloor2();
        }
        if (selectedText == "Floor3") {
            scene.OpenFloor3();
        }
        if (selectedText == "Floor4") {
            scene.OpenFloor4();
        }
        if (selectedText == "Floor5") {
            scene.OpenFloor5();
        }
        if (selectedText == "1000+") {
            scene.OpenMap1();
        }
        if (selectedText == "2000+") {
            scene.OpenMap2();
        }
        if (selectedText == "3000+") {
            scene.OpenMap3();
        }
        if (selectedText == "4000+") {
            scene.OpenMap4();
        }
    }

    public void Map() {
        isArActive = !isArActive;   
        isMapActive = !isMapActive;
        arCamera.gameObject.SetActive(isArActive);
        topCamera.gameObject.SetActive(isMapActive);
    }
}