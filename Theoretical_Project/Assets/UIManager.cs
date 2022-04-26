using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI welcomeText;

    void Awake() {
        welcomeText.text = $"Welcome {GameManager.Instance.nameInput}. Destroy your enemies.";
    }

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }
}
