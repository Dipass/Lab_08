using System;

class Box<T> where T : IComparable<T>
{
    public T box { get; set; }

    public Box(T boxs)
    {
        box = boxs;
    }

    public bool Count(T select)
    {
        if (box.CompareTo(select) > 0)
        {
            return true;
        }
        else if (box.CompareTo(select) < 0)
        {
            return false;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"Output {typeof(T).FullName}:{box}";
    }
}