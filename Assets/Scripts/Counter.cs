using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.U2D;

public class Counter : MonoBehaviour
{
  public  Sprite[] nums = new Sprite[10];
   public static int currentScore = 0;
    SpriteRenderer unit;
    SpriteRenderer ten;
    SpriteRenderer hundred;
    public GameObject Unit;
    public GameObject Ten;
    public GameObject Hundred;
    float unitPosX = 0;
    private void Start()
    {
        unitPosX = Unit.transform.position.x;
        unit = Unit.GetComponent<SpriteRenderer>();
        ten = Ten.GetComponent<SpriteRenderer>();
        hundred = Hundred.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        //if (MenuManager.canPlay == false)
        //{
        //    return;
        //} 
        if (currentScore < 10)
        {
            unit.sprite = nums[currentScore];
            Unit.transform.position = new Vector2(unitPosX,unit.transform.position.y);
            ten.sprite = nums[10];
            hundred.sprite = nums[10];
        }
        if(currentScore > 9) 
        {
            
            int units = (currentScore / 10) % 10;
            int tens = currentScore % 10;
            unit.sprite = nums[units];
            ten.sprite = nums[tens];
         
          
               Unit.transform.position = new Vector2(1.65f,unit.transform.position.y);
            
         
        }
        if (currentScore > 99)
        {
            int units = currentScore % 10;
            int tens = (currentScore / 10) % 10; ;
            int hundreds = currentScore / 100;
            unit.sprite = nums[units];
            ten.sprite = nums[tens];
            hundred.sprite = nums[hundreds];
            Ten.transform.position = new Vector2(2,ten.transform.position.y);
            Unit.transform.position = new Vector2(2.2f, unit.transform.position.y);
        }
    }
    public void UpdateCounter()
    {
        if (currentScore < 10)
        {
           ;
        }
    } 
   
}
