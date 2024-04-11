using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public UnityEngine.UI.Image bar;
    public TMP_Text text;
    public Entity trackedEntity;

    // Start is called before the first frame update
    void Start()
    {
        updateHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        updateHealthBar();
    }

    private void updateHealthBar()
    {
        if (trackedEntity != null)
        {
            float currentHealth = trackedEntity.getCurrentHealth();
            
            bar.rectTransform.localScale = new Vector3(currentHealth / trackedEntity.maxHealth, 1, 1);
            text.SetText(currentHealth + "/" + trackedEntity.maxHealth);

            this.gameObject.transform.SetParent(trackedEntity.gameObject.transform, false);
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
