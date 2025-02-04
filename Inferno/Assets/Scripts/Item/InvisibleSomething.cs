﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleSomething : Item {

    public InvisibleSomething()
    {
        type = itemList.INVISIBLESOMETHING;
        amount = 0;
        int[] temp = { 1000, 2000 };
        cost = temp;
        label = "보이지않는 무언가";
    }

    public InvisibleSomething(int num)
    {
        type = itemList.INVISIBLESOMETHING;
        amount = num;
        int[] temp = { 1000, 2000 };
        cost = temp;
        label = "보이지않는 무언가";
    }

    public override void use()
	{
        GameManager.Inst().all_Items[itemList.INVISIBLESOMETHING].amount--;
        if (GameManager.Inst().all_Items[itemList.INVISIBLESOMETHING].amount == 0)
            GameManager.Inst().itemList.Remove(GameManager.Inst().all_Items[itemList.INVISIBLESOMETHING]); 
    }
}
