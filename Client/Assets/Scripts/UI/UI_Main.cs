using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_Main : MonoBehaviour
{
    [SerializeField] public GameObject _elements = null;
    [SerializeField] public TextMeshProUGUI _foodText = null;
    [SerializeField] public TextMeshProUGUI _woodText = null;
    [SerializeField] public TextMeshProUGUI _stoneText = null;
    [SerializeField] public TextMeshProUGUI _goldText = null;
    [SerializeField] public TextMeshProUGUI _gemText = null;
    [SerializeField] public Button _structureButton = null;

    [SerializeField] private Building[] _buildingPrefabs = null;

    private static UI_Main _instance = null;
    public static UI_Main instance { get { return _instance; }}
    private bool _active = true; public bool isActive {get { return _active;}}

    private void Awake()
    {
        _instance = this;
        _elements.SetActive(true);
    }

    private void Start()
    {
        _structureButton.onClick.AddListener(StructureButtonClicked);
    }

    private void StructureButtonClicked()
    {
        UI_Structure.instance.SetStatus(true);
        SetStatus(false);
    }
    public void SetStatus(bool status)
    {
        _active = status;
        _elements.SetActive(status);
    }
}
