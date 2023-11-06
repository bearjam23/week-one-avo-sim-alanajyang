using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class avoMove : MonoBehaviour
{

    public TextMeshProUGUI countText;
    public int fullCount = 100;
    public float currCount = 100;
    public Sprite teen;
    public Sprite elder;
    public Sprite final;

    [SerializeField] Rigidbody2D avo;//4 our bb cado
    [SerializeField] float speed;  //cado zoom rate
    [SerializeField] float jump;

    private float direction;

    private void Start()
    {
        currCount = fullCount;
        countText.text = currCount.ToString();
    }

    // Start is called before the first frame update
    public void OnMouseDown() //speical unity func 
    {
        currCount -= 1;
        countText.text = currCount.ToString();
        if (currCount == 66)
        {
            this.GetComponent<SpriteRenderer>().sprite = teen;
        } else if (currCount == 33)
        {
            this.GetComponent<SpriteRenderer>().sprite = elder;
        } else if (currCount <= 0)
        {
            countText.text = "FINAL FORM!!! :0";
            this.GetComponent<SpriteRenderer>().sprite = final;
        }
    }
    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal"); // -1 for left +1 for right
        if (Input.GetButtonDown("Jump"))
        {
            avo.velocity = new Vector2(avo.velocity.x, jump);
        }                            
    }

    //for special physics updates 
    void FixedUpdate()
    {
        avo.velocity = new Vector2(speed * direction, avo.velocity.y);
    }
}
