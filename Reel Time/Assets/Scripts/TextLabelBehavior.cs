using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
   public Text label;
   public UnityEvent startEvent;
   
   private void Start()
   {
      label = GetComponent<Text>();
      startEvent.Invoke();
   }

   public void UpdateLabel(FloatData obj)
   {
      label.text = obj.value.ToString(CultureInfo.InvariantCulture);
   }
   
   public void UpdateLabel(IntData obj)
   {
      label.text = obj.value.ToString(CultureInfo.InvariantCulture);
   }

   public void UpdateLabel(FishData fish)
   {
      label.text = ("fish price: " + fish.value.ToString(CultureInfo.InvariantCulture));
   }


}
