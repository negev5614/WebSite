using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cart
/// </summary>
public class Cart
{
    public Item[] ArrItem;
    public int Size;
    public Cart()
    {
        ArrItem = new Item[100];
        Size = 0;
    }
    public void AddtoCart(Item tmp)//הוספה לסל
    {
        int i;
        for (i = 0; i < Size; i++)
        {
            if (ArrItem[i].pid == tmp.pid)
            {
                ArrItem[i].amount++;
                break;
            }
        }
        if (i== Size)
            {
                 ArrItem[Size] = tmp;
                Size++;
            }
       
    }
    public void EmptyCart()//ריקון כל סל הניות
    {
        Size = 0;
    }
    public void RemoveFromCart(int pid)
    {
        for (int i = 0; i < Size; i++)
        {
            if (ArrItem[i].pid == pid)
            {
                for (int j = i; j < Size - 1; j++)
                {
                    ArrItem[j] = ArrItem[j + 1];
                }
                Size--;
                
            }
        }
    }
    public void removone(Item ed)//ריקון מוצר בודד כמות
    {
        if (Size >= 1)
        {
            for(int i = 0; i < Size; i++)
            {
                if (ArrItem[i].pid == ed.pid)
                {
                    if (ArrItem[i].amount >= 1)
                    {
                        ArrItem[i].amount--;
                        break;
                    }
                    else if (ArrItem[i].amount <0)
                    {
                        EmptyCart();
                    }

                }
            }
        }
    }
    public void adding(Item ad)
    {
        if (Size >= 1)
        {
            for (int i = 0; i < Size; i++)
            {
                if (ArrItem[i].pid == ad.pid)
                {
                    ArrItem[i].amount++;
                    break;
                }
            }
        }

    }
}